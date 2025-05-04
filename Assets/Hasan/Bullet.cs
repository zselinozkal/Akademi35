using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    public int damage = 1;

    private Vector2 moveDirection;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void SetDirection(Vector2 direction)
    {
        moveDirection = direction.normalized;
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = moveDirection * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Eğer hedef düşmansa hasar ver
        EnemyHealth enemy = other.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }

        // Eğer kendi karakterinse hiçbir şey yapma
        if (other.CompareTag("Enemy"))
            return;

        // Her şeye çarpınca yok olsun
        Destroy(gameObject);
    }
}