using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using TMPro;
using UnityEngine;

public class LevelEditor : MonoBehaviour
{
    [SerializeField]
    private Transform _cursor;
    [SerializeField]
    private int _tileSize = 1;
    [SerializeField]
    private TMP_Text _currentBlockDisplayText;
    [SerializeField]
    private TilePrefabLookup _lookup;
    [SerializeField]
    private TMP_InputField _levelNameInput;

    private LevelData _levelData;
    private List<LevelEditorTile> _generatedTiles;

    private int _currentX;
    private int _currentY;
    private int _currentZ;
    private BlockType _currentBlockType;
    
    void Start()
    {
        // TODO: Allow loading an existing level in for init state.
        _generatedTiles = new List<LevelEditorTile>();
        _levelData = new LevelData
        {
            TileLayout = new TileData[0]
        };
        UpdateBlockTypeDisplay();
        UpdateCursor();
    }
    
    void Update()
    {
        ProcessCycleBlockType();
        ProcessCursorMovement();
        ProcessBlockPlacement();
        ProcessSaveLevel();
    }

    private void ProcessCycleBlockType()
    {
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            CycleBlockBackwards();
        else if (Input.GetKeyUp(KeyCode.RightArrow))
            CycleBlockForward();
    }

    private void ProcessCursorMovement()
    {
        if (Input.GetKeyUp(KeyCode.W))
            MoveCursorForwards();

        if (Input.GetKeyUp(KeyCode.S))
            MoveCursorBackwards();

        if (Input.GetKeyUp(KeyCode.A))
            MoveCursorLeft();

        if (Input.GetKeyUp(KeyCode.D))
            MoveCursorRight();

        if (Input.GetKeyUp(KeyCode.Q))
            MoveCursorUp();

        if (Input.GetKeyUp(KeyCode.E))
            MoveCursorDown();
    }

    private void MoveCursorForwards()
    {
        _currentZ += _tileSize;
        UpdateCursor();
    }

    private void MoveCursorBackwards()
    {
        _currentZ -= _tileSize;
        UpdateCursor();
    }

    private void MoveCursorLeft()
    {
        _currentX -= _tileSize;
        UpdateCursor();
    }
    private void MoveCursorRight()
    {
        _currentX += _tileSize;
        UpdateCursor();
    }

    private void MoveCursorUp()
    {
        _currentY += _tileSize;
        UpdateCursor();
    }

    private void MoveCursorDown()
    {
        _currentY -= _tileSize;
        UpdateCursor();
    }

    private void UpdateCursor()
    {
        _cursor.position = new Vector3(_currentX, _currentY, _currentZ);
    }

    private void ProcessBlockPlacement()
    {
        if (Input.GetKeyUp(KeyCode.F))
            SetTile();
    }

    private void ProcessSaveLevel()
    {
        if (Input.GetKeyUp(KeyCode.Z))
            SaveLevel();
    }

    private void SetTile()
    {
        if (_currentBlockType == BlockType.None)
            EraseCurrentTile();
        else
            AddCurrentTile();
    }
    
    private void EraseCurrentTile()
    {
        if (!_levelData.TileLayout.Any(d => d.X == _currentX && d.Y == _currentY && d.Z == _currentZ))
            return;

        _levelData.TileLayout = _levelData.TileLayout.ToList().Where(d => d.X != _currentX || d.Y != _currentY || d.Z != _currentZ).ToArray();

        RemoveCurrentTile();
    }
    
    private void AddCurrentTile()
    {
        if (_levelData.TileLayout.Any(d => d.X == _currentX && d.Y == _currentY && d.Z == _currentZ))
        {
            _levelData.TileLayout.First(d => d.X == _currentX && d.Y == _currentY && d.Z == _currentZ).Type = _currentBlockType;
            RemoveCurrentTile();
        }
        else
        {
            var levelDataList = _levelData.TileLayout.ToList();
            levelDataList.Add(new TileData{Type = _currentBlockType, X = _currentX, Y = _currentY, Z = _currentZ});
            _levelData.TileLayout = levelDataList.ToArray();
        }

        var currentPos = new Vector3(_currentX, _currentY, _currentZ);
        var newObj = Instantiate(_lookup.GetPrefab(_currentBlockType), currentPos, Quaternion.identity);
        _generatedTiles.Add(new LevelEditorTile
        {
            GeneratedObject = newObj,
            X = _currentX,
            Y = _currentY,
            Z = _currentZ
        });
    }

    private void RemoveCurrentTile()
    {
        if (!_generatedTiles.Any(t => t.X == _currentX && t.Y == _currentY && t.Z == _currentZ))
            return;

        var tile = _generatedTiles.First(t => t.X == _currentX && t.Y == _currentY && t.Z == _currentZ);
        Destroy(tile.GeneratedObject);
        _generatedTiles.Remove(tile);
    }

    // TODO: Update visual indicator to player when this happens!
    private void CycleBlockBackwards()
    {
        var nextBlockIndex = (int)_currentBlockType - 1;
        if (nextBlockIndex < 0)
        {
            var blockTypes = Enum.GetValues(typeof(BlockType));
            nextBlockIndex = (int)blockTypes.GetValue(blockTypes.Length - 1);
        }
        _currentBlockType = (BlockType)nextBlockIndex;
        UpdateBlockTypeDisplay();
    }

    // TODO: Update visual indicator to player when this happens!
    private void CycleBlockForward()
    {
        var nextBlockIndex = (int)_currentBlockType + 1;
        var blockTypes = Enum.GetValues(typeof(BlockType));
        if (nextBlockIndex >= blockTypes.Length)
            nextBlockIndex = 0;
        _currentBlockType = (BlockType)nextBlockIndex;
        UpdateBlockTypeDisplay();
    }

    private void UpdateBlockTypeDisplay()
    {
        _currentBlockDisplayText.text = _currentBlockType.ToString();
    }

    private void SaveLevel()
    {
        // TODO: Do something better than debug.log!!!
        if (string.IsNullOrEmpty(_levelNameInput.text))
        {
            Debug.LogError("CANNOT SAVE FILE, NO LEVEL NAME GIVEN!");
            return;
        }

        var dir = Path.Combine(Application.persistentDataPath, "CustomLevels");
        if(!Directory.Exists(dir))
            Directory.CreateDirectory(dir);
        var filePath = Path.Combine(dir, $"{_levelNameInput.text}.level");

        // TODO: Do something better than debug.log!!!
        if (File.Exists(filePath))
            Debug.LogError($"CANNOT SAVE LEVEL '{_levelNameInput.text}', LEVEL ALREADY EXISTS!");
        else
        {
            var levelDataJson = JsonConvert.SerializeObject(_levelData, Formatting.None);
            File.WriteAllText(filePath, levelDataJson);
        }
    }
}
