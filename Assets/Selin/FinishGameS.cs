using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGameS : MonoBehaviour
{
    public string targetScene;

    void Update()
    {
        if (CollectibleTracker.collectedCount == 12 && Input.GetKeyDown(KeyCode.B))
        {
            // Save the player's position before switching scenes
            

            // Switch to the target scene
            SceneManager.LoadScene(targetScene);
        }
    }
    
}
