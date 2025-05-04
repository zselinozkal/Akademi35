using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerS : MonoBehaviour
{
    public static GameManager Instance;

    [HideInInspector] public int collectedCount = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
