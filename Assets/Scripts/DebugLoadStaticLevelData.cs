using System.IO;
using Newtonsoft.Json;
using UnityEngine;

public class DebugLoadStaticLevelData : MonoBehaviour
{
    private bool _loaded;
    
    void Update()
    {
        if (_loaded) return;

        LoadLevel();
    }

    private void LoadLevel()
    {
        var filepath = Path.Combine(Application.persistentDataPath, "CustomLevels", "test.level");
        var dataJson = File.ReadAllText(filepath);
        var data = JsonConvert.DeserializeObject<LevelData>(dataJson);
        var generator = FindObjectOfType<LevelGenerator>();
        generator.GenerateLevel(data);
        _loaded = true;
    }
}
