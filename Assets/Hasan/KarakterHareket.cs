using UnityEngine;

public class KarakterHareket : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveInput = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            moveInput = -1f;
            transform.localScale = new Vector3(-1, 1, 1); // Sola d�n
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveInput = 1f;
            transform.localScale = new Vector3(1, 1, 1); // Sa�a d�n
        }

        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
    }
}
