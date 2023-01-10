using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

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
    [SerializeField]
    private GameObject _mainEditorCanvas;
    [SerializeField]
    private GameObject _minimizedEditorCanvas;
    [SerializeField]
    private LevelEditorControls _editorControls;

    private InputAction _moveXZ;
    private InputAction _moveUp;
    private InputAction _moveDown;
    private InputAction _cycleTileForwards;
    private InputAction _cycleTileBackwards;
    private InputAction _placeTile;
    private InputAction _saveLevel;
    private InputAction _minimizeUi;


    private LevelData _levelData;
    private List<LevelEditorTile> _generatedTiles;

    private int _currentX;
    private int _currentY;
    private int _currentZ;
    private BlockType _currentBlockType;
    private bool _minimized;

    void Awake()
    {
        _editorControls = new LevelEditorControls();
    }

    void OnEnable()
    {
        _moveXZ = _editorControls.Player.MoveXZ;
        _moveUp = _editorControls.Player.MoveUp;
        _moveDown = _editorControls.Player.MoveDown;
        _cycleTileForwards = _editorControls.Player.CycleTileForwards;
        _cycleTileBackwards = _editorControls.Player.CycleTileBackwards;
        _placeTile = _editorControls.Player.PlaceTile;
        _saveLevel = _editorControls.Player.SaveLevel;
        _minimizeUi = _editorControls.Player.MinimizeUi;

        _moveXZ.Enable();
        _moveUp.Enable();
        _moveDown.Enable();
        _cycleTileForwards.Enable();
        _cycleTileBackwards.Enable();
        _placeTile.Enable();
        _saveLevel.Enable();
        _minimizeUi.Enable();

        _moveXZ.performed += OnMoveCursor;
        _moveUp.performed += OnMoveCursorUp;
        _moveDown.performed += OnMoveCursorDown;
        _cycleTileForwards.performed += OnCycleTileForward;
        _cycleTileBackwards.performed += OnCycleTileBackwards;
        _placeTile.performed += OnPlaceBlock;
        _saveLevel.performed += OnSaveLevel;
        _minimizeUi.performed += OnMinimize;
    }

    void OnDisable()
    {
        _moveXZ.Disable();
        _moveUp.Disable();
        _moveDown.Disable();
        _cycleTileForwards.Disable();
        _cycleTileBackwards.Disable();
        _placeTile.Disable();
        _saveLevel.Disable();
        _minimizeUi.Disable();
    }
    
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

    private void ToggleMinimize()
    {
        if (_minimized)
        {
            _mainEditorCanvas.SetActive(true);
            _minimizedEditorCanvas.SetActive(false);
        }
        else
        {
            _mainEditorCanvas.SetActive(false);
            _minimizedEditorCanvas.SetActive(true);
        }

        _minimized = !_minimized;
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

    private void OnMoveCursor(InputAction.CallbackContext context)
    {
        var moveDir = context.ReadValue<Vector2>();
        if(moveDir.x > 0)
            MoveCursorRight();
        else if(moveDir.x < 0)
            MoveCursorLeft();
        if(moveDir.y > 0)
            MoveCursorForwards();
        else if(moveDir.y < 0)
            MoveCursorBackwards();
    }

    private void OnMoveCursorUp(InputAction.CallbackContext context)
    {
        MoveCursorUp();
    }

    private void OnMoveCursorDown(InputAction.CallbackContext context)
    {
        MoveCursorDown();
    }

    private void OnCycleTileForward(InputAction.CallbackContext context)
    {
        CycleBlockForward();
    }

    private void OnCycleTileBackwards(InputAction.CallbackContext context)
    {
        CycleBlockBackwards();
    }

    private void OnPlaceBlock(InputAction.CallbackContext context)
    {
        SetTile();
    }

    private void OnSaveLevel(InputAction.CallbackContext context)
    {
        SaveLevel();
    }

    private void OnMinimize(InputAction.CallbackContext context)
    {
        ToggleMinimize();
    }
}
