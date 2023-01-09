using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField]
    private float _tileSize = 1;
    [SerializeField]
    private TilePrefabLookup TileDictionary;

    public void GenerateLevel(LevelData levelData)
    {
        // TODO: Set music based on music setting.
        // TODO: Set background based on background setting.

        for (var i = 0; i < levelData.TileLayout.Length; i++)
        {
            var tile = levelData.TileLayout[i];
            GenerateTile(tile);
        }
    }

    private void GenerateTile(TileData tile)
    {
        var prefab = TileDictionary.GetPrefab(tile.Type);
        if (prefab == null) return;

        var tilePosition = ConvertToPosition(tile);
        Instantiate(prefab, tilePosition, Quaternion.identity);
    }

    private Vector3 ConvertToPosition(TileData tile)
    {
        return new Vector3(tile.X * _tileSize, tile.Y * _tileSize, tile.Z * _tileSize);
    }
}
