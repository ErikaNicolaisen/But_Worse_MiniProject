using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private GameObject explosionEffect; // Optional: effect on enemy hit

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the projectile hit an object tagged "Enemy"
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Instantiate explosion effect if provided
            if (explosionEffect != null)
            {
                Instantiate(explosionEffect, collision.transform.position, Quaternion.identity);
            }

            // Destroy the enemy and the projectile
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else
        {
            // Destroy the projectile on any other collision
            Destroy(gameObject);
        }
    }
}
