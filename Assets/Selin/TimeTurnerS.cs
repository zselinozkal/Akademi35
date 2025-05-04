using UnityEngine;

public class TimeTurnerS : MonoBehaviour
{
    public GameObject sprite1; // First sprite (will toggle off/on)
    public GameObject sprite2; // Second sprite (will toggle on/off)

    private bool isSprite1Active = true; // Track which sprite is currently active

    void Update()
    {
        // Check if the "F" key is pressed
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Toggle the visibility of the sprites
            if (isSprite1Active)
            {
                sprite1.GetComponent<Renderer>().enabled = false; // Disable sprite1's mesh
                sprite2.GetComponent<Renderer>().enabled = true;  // Enable sprite2's mesh
            }
            else
            {
                sprite1.GetComponent<Renderer>().enabled = true;  // Enable sprite1's mesh
                sprite2.GetComponent<Renderer>().enabled = false; // Disable sprite2's mesh
            }

            // Switch active state
            isSprite1Active = !isSprite1Active;
        }
    }
}
