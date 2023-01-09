using UnityEngine;

public class DebugFakeLevelData : MonoBehaviour
{
    private bool _initialized;
    
    private void Update()
    {
        if (_initialized) return;

        GenerateLevel();
    }

    private void GenerateLevel()
    {
#region Hard_Coded_Data
        var fakeLevel = new LevelData
        {
            LevelSong = Song.Song1,
            LevelBackground = Background.Sky,
            TileLayout = new[]
            {
                new TileData {Type = BlockType.Floor1, X = 0, Y = 0, Z = 0 },
                new TileData {Type = BlockType.Floor1, X = 1, Y = 0, Z = 0 },
                new TileData {Type = BlockType.Floor1, X = 0, Y = 0, Z = 1 },
                new TileData {Type = BlockType.Floor2, X = 1, Y = 0, Z = 1 },
                new TileData {Type = BlockType.Floor1, X = 1, Y = 0, Z = 2 },
                new TileData {Type = BlockType.Floor1, X = 2, Y = 0, Z = 1 },
                new TileData {Type = BlockType.Floor1, X = 2, Y = 0, Z = 2 },
                new TileData {Type = BlockType.Floor1, X = 0, Y = 0, Z = 2 },
                new TileData {Type = BlockType.Floor1, X = 2, Y = 0, Z = 0 },
                new TileData {Type = BlockType.UnbreakableWall1, X = -1, Y = 1, Z = -1 },
                new TileData {Type = BlockType.UnbreakableWall1, X = 0, Y = 1, Z = -1 },
                new TileData {Type = BlockType.UnbreakableWall1, X = 1, Y = 1, Z = -1 },
                new TileData {Type = BlockType.UnbreakableWall1, X = 2, Y = 1, Z = -1 },
                new TileData {Type = BlockType.UnbreakableWall1, X = 3, Y = 1, Z = -1 },
                new TileData {Type = BlockType.UnbreakableWall1, X = 3, Y = 1, Z = 0 },
                new TileData {Type = BlockType.UnbreakableWall1, X = 3, Y = 1, Z = 1 },
                new TileData {Type = BlockType.UnbreakableWall1, X = 3, Y = 1, Z = 2 },
                new TileData {Type = BlockType.UnbreakableWall1, X = 3, Y = 1, Z = 3 },
                new TileData {Type = BlockType.UnbreakableWall1, X = 2, Y = 1, Z = 3 },
                new TileData {Type = BlockType.UnbreakableWall1, X = 1, Y = 1, Z = 3 },
                new TileData {Type = BlockType.UnbreakableWall1, X = 0, Y = 1, Z = 3 },
                new TileData {Type = BlockType.UnbreakableWall1, X = -1, Y = 1, Z = 3 },
                new TileData {Type = BlockType.UnbreakableWall1, X = -1, Y = 1, Z = 2 },
                new TileData {Type = BlockType.UnbreakableWall1, X = -1, Y = 1, Z = 1 },
                new TileData {Type = BlockType.UnbreakableWall1, X = -1, Y = 1, Z = 0 },
            }
        };
#endregion

        var levelGenerator = FindObjectOfType<LevelGenerator>();
        levelGenerator.GenerateLevel(fakeLevel);

        _initialized = true;
    }
}
