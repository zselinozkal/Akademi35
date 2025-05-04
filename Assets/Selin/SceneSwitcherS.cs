using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcherS : MonoBehaviour
{
    public string targetScene;  // The name of the scene to switch to
    private bool isTouchingObjectA = false;

    void Update()
    {
        if (isTouchingObjectA && Input.GetKeyDown(KeyCode.F))
        {
            // Save the player's position before switching scenes
            ScenePositionMemoryS.lastPosition = transform.position;
            ScenePositionMemoryS.hasSavedPosition = true;

            // Switch to the target scene
            SceneManager.LoadScene(targetScene);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ObjectA"))  // Make sure Object A has the tag "ObjectA"
        {
            isTouchingObjectA = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("ObjectA"))
        {
            isTouchingObjectA = false;
        }
    }
}
