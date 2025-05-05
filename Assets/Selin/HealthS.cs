using UnityEngine;

public class HealthS : MonoBehaviour
{

    private bool playerInCanavarRange = false;
    
    private bool isInTouch = false;
    
    void Update()
    {
        if (playerInCanavarRange)
        {
            isInTouch = false; // tekrar tetiklenmesini engelle

            CollectibleTracker.healthCount = CollectibleTracker.healthCount - 10;
            FindObjectOfType<HealthUI>()?.UpdateCountText();
            
            
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Canavar1"))
            playerInCanavarRange = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Canavar1"))
            playerInCanavarRange = false;
    }
    
}
