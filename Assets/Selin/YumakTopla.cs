using UnityEngine;

public class YumakTopla : MonoBehaviour
{
    private bool playerInRange = false;
    AudioSource _audio;
    private bool isCollected = false;
    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            isCollected = true; // tekrar tetiklenmesini engelle

            CollectibleTracker.collectedCount++;
            FindObjectOfType<YumakUI>()?.UpdateCountText();
            GetComponent<SpriteRenderer>().enabled = false;
            _audio.Play();
            // Sesin s�resi kadar sonra nesneyi yok et
            Destroy(gameObject, _audio.clip.length);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            playerInRange = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            playerInRange = false;
    }
}
