using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginLevel : MonoBehaviour
{
    private Scene _scene;

    private void Awake()
    {
        _scene = SceneManager.GetActiveScene();
    }

    public void StartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
