using UnityEngine;
using System.Collections;

public class ScenePositionRestorerS : MonoBehaviour
{
    IEnumerator Start()
    {
        // Wait one frame to ensure the scene is fully loaded
        yield return null;

        if (ScenePositionMemoryS.hasSavedPosition)
        {
            // Set the player's position to the saved position from the previous scene
            transform.position = ScenePositionMemoryS.lastPosition;

            // Reset the flag so we don't keep overriding position
            ScenePositionMemoryS.hasSavedPosition = false;
        }
    }
}
