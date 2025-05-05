using UnityEngine;
using UnityEngine.SceneManagement;

public class fallS : MonoBehaviour
{
    private bool isTouchingObjectA = false;
    void Update()
    {
        if (isTouchingObjectA )
        {
            
            SceneManager.LoadScene("kaybetme");
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  // Make sure Object A has the tag "ObjectA"
        {
            isTouchingObjectA = true;
        }
    }
}
