using UnityEngine;

public class ClimbController : MonoBehaviour
{
    public float climbSpeed = 3f;

    private bool isTouchingClimbable = false;
    private bool isClimbing = false;

    private Rigidbody2D rb;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (isTouchingClimbable && Input.GetKey(KeyCode.C))
        {
            isClimbing = true;
            rb.gravityScale = 0f;
            transform.Translate(Vector2.up * climbSpeed * Time.deltaTime);
        }
        else
        {
            isClimbing = false;
            rb.gravityScale = 1.5f;
        }

        // Update Animator
        if (animator != null)
        {
            animator.SetBool("isClimbing", isClimbing);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Climbable"))
        {
            isTouchingClimbable = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Climbable"))
        {
            isTouchingClimbable = false;
        }
    }
}
