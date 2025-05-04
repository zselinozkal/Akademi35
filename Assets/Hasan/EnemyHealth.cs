using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 3; // Düþmanýn baþlangýç caný
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Mermi düþmana çarptýðýnda çaðrýlacak
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
        Destroy(gameObject); // Düþmaný sahneden kaldýr
    }
}
