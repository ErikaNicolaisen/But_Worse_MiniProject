using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private GameObject projectilePrefab; // Reference to the projectile prefab
    [SerializeField] private float shootingRange = 100f;
    [SerializeField] private float projectileSpeed = 20f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Create a ray from the camera towards the mouse position
        Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Define a target point for the projectile to move towards
        Vector3 targetPoint;

        if (Physics.Raycast(ray, out hit, shootingRange))
        {
            // Set target point to the hit location if something is hit
            targetPoint = hit.point;
        }
        else
        {
            // Set target point to a distant point along the ray if nothing is hit
            targetPoint = ray.GetPoint(shootingRange);
        }

        // Instantiate the projectile at the player's position
        GameObject projectile = Instantiate(projectilePrefab, playerCamera.transform.position, Quaternion.identity);

        // Calculate direction and set projectile velocity
        Vector3 direction = (targetPoint - playerCamera.transform.position).normalized;
        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();

        if (projectileRb != null)
        {
            projectileRb.velocity = direction * projectileSpeed;
        }
    }
}
