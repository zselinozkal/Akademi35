using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 3; // D��man�n ba�lang�� can�
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Mermi d��mana �arpt���nda �a�r�lacak
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject); // D��man� sahneden kald�r
    }
}
