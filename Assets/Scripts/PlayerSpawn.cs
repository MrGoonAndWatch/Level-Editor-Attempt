using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject _uiIndicator;
    
    void Start()
    {
        if(!SceneManager.GetActiveScene().name.Equals("LevelEditor"))
            _uiIndicator.SetActive(false);
    }
}
