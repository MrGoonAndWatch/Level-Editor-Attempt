using System;
using System.Collections.Generic;
using UnityEngine;

public class TilePrefabLookup : MonoBehaviour
{
    [SerializeField]
    private TileLookup[] Lookup;

    private Dictionary<BlockType, GameObject> _dictLookup;

    private void Start()
    {
        _dictLookup = new Dictionary<BlockType, GameObject>();

        for (var i = 0; i < Lookup.Length; i++)
        {
            var lookup = Lookup[i];
            if (_dictLookup.ContainsKey(lookup.Type))
                Debug.LogWarning($"More than one prefab mapping found for BlockType '{lookup.Type}'! Only mapping the first prefab listed!");
            else
                _dictLookup.Add(lookup.Type, lookup.Prefab);
        }
    }

    public GameObject GetPrefab(BlockType type)
    {
        if (_dictLookup.ContainsKey(type))
            return _dictLookup[type];

        Debug.LogError($"Unknown BlockType passed in '{type}', cannot find prefab for this type!");
        return null;
    }
}

[Serializable]
public class TileLookup
{
    public BlockType Type;
    public GameObject Prefab;
}