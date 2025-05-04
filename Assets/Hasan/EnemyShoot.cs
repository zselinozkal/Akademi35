using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyShoot : MonoBehaviour
{

    public Transform shootingPoint;       // Merminin çıkacağı yer
    public GameObject bulletPrefab;       // Mermi prefabı
    public Transform player;              // Ana karakterin Transform'u
    public float fireRate = 1f;           // Ateş etme sıklığı (saniye)
    public float detectionRange = 3f;     // Ateş etmek için gereken mesafe

    private float fireCooldown = 0f;

    void Update()
    {
        if (player == null) return;

        float distance = Vector2.Distance(transform.position, player.position);

        // Sadece oyuncu yakındaysa ateş et
        if (distance <= detectionRange)
        {
            fireCooldown -= Time.deltaTime;

            if (fireCooldown <= 0f)
            {
                Shoot();
                fireCooldown = fireRate;
            }
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, shootingPoint.position, Quaternion.identity);
        Destroy(bullet, 1f); // 1 saniye sonra mermiyi yok et
    }
}
