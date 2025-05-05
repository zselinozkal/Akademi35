using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGameS : MonoBehaviour
{
    public string targetScene;
    private bool isTouchingObjectB = false;

    void Update()
    {
        if (CollectibleTracker.collectedCount == 12 && Input.GetKeyDown(KeyCode.B) && isTouchingObjectB == true)
        {
            // Save the player's position before switching scenes
            

            // Switch to the target scene
            SceneManager.LoadScene(targetScene);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ObjectB"))  // Make sure Object A has the tag "ObjectA"
        {
            isTouchingObjectB = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("ObjectB"))
        {
            isTouchingObjectB = false;
        }
    }

}
