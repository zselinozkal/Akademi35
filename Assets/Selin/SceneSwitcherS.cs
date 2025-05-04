using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcherS : MonoBehaviour
{
    public string targetScene;  // The name of the scene you want to switch to

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))  // Change to whatever button you want for scene switch
        {
            // Save the player's position before switching scenes
            ScenePositionMemoryS.lastPosition = transform.position;
            ScenePositionMemoryS.hasSavedPosition = true;

            // Switch to the target scene
            SceneManager.LoadScene(targetScene);
        }
    }
}
