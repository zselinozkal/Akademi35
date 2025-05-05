using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class HealthS : MonoBehaviour
{
    public List<Image> healthImage;
    private bool playerInCanavarRange = false;
    private bool isInTouch = false;
    

    void Start()
    {
        // Eðer can 0 ise, yeni sahnede sýfýrla
        if (CollectibleTracker.healthCount <= 0)
        {
            CollectibleTracker.ResetHealth();
        }

        UpdateUI();
    }

    void Update()
    {
        if (playerInCanavarRange && !isInTouch)
        {
            isInTouch = true;
            if (CollectibleTracker.healthCount > 0)
            {
                CollectibleTracker.healthCount--;
                UpdateUI();
                Debug.Log("Can azaldý. Kalan can: " + CollectibleTracker.healthCount);

                if (CollectibleTracker.healthCount == 0)
                {
                    SceneManager.LoadScene("kaybetme");
                }
            }
        }
    }

    void UpdateUI()
    {
        for (int i = 0; i < healthImage.Count; i++)
        {
            healthImage[i].enabled = (i < CollectibleTracker.healthCount);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            playerInCanavarRange = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInCanavarRange = false;
            isInTouch = false;
        }
    }
}