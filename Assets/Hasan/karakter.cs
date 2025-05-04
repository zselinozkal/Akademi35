using UnityEngine;

public class karakter : MonoBehaviour
{
    public float speed = 2f;
    public float moveDistance = 3f;
    public float waitTime = 0.5f;
    public float detectionRange = 5f;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireCooldown = 1.5f;
    public Transform target;

    private Vector2 initialPosition;
    private int direction = 1;
    private Rigidbody2D rb;
    private bool isWaiting = false;
    private float waitTimer = 0f;
    private SpriteRenderer spriteRenderer;
    private float fireTimer = 0f;
    private bool playerInRange = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        initialPosition = transform.position;
    }

    void Update()
    {
        fireTimer -= Time.deltaTime;

        if (target != null)
        {
            float distanceToPlayer = Vector2.Distance(transform.position, target.position);
            playerInRange = distanceToPlayer <= detectionRange;
        }

        if (playerInRange)
        {
            bool lookLeft = (target.position.x < transform.position.x);
            spriteRenderer.flipX = lookLeft;

            Vector3 firePos = firePoint.localPosition;
            firePos.x = Mathf.Abs(firePos.x) * (lookLeft ? -1 : 1);
            firePoint.localPosition = firePos;

            rb.linearVelocity = Vector2.zero;

            if (fireTimer <= 0f)
            {
                Fire();
                fireTimer = fireCooldown;
            }

            return;
        }

        if (isWaiting)
        {
            waitTimer -= Time.deltaTime;
            if (waitTimer <= 0f)
                isWaiting = false;
            else
            {
                rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
                return;
            }
        }

        rb.linearVelocity = new Vector2(direction * speed, rb.linearVelocity.y);
        spriteRenderer.flipX = direction < 0;

        float traveled = transform.position.x - initialPosition.x;
        if (direction == 1 && traveled >= moveDistance)
        {
            direction = -1;
            StartWait();
        }
        else if (direction == -1 && traveled <= -moveDistance)
        {
            direction = 1;
            StartWait();
        }
    }

    void StartWait()
    {
        isWaiting = true;
        waitTimer = waitTime;
        rb.linearVelocity = Vector2.zero;
    }

    void Fire()
    {
        if (bulletPrefab != null && firePoint != null)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

            Vector2 direction = (target.position.x < transform.position.x) ? Vector2.left : Vector2.right;

            Bullet bulletScript = bullet.GetComponent<Bullet>();
            if (bulletScript != null)
                bulletScript.SetDirection(direction);

            if (direction == Vector2.left)
                bullet.GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}