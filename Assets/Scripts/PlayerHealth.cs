using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameObject playerExplosionPrefab;
    [SerializeField] private Camera playerCamera;
    public static bool isPlayerAlive = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pipes") ||
            collision.gameObject.CompareTag("Road") ||
            collision.gameObject.CompareTag("Enemy"))
        {
            if (isPlayerAlive)
            {
                StartCoroutine(Die());
            }
        }
    }

    private IEnumerator Die()
    {
        isPlayerAlive = false;
        playerCamera.transform.SetParent(null);
        Instantiate(playerExplosionPrefab, transform.position, transform.rotation);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
        Destroy(gameObject);
    }
}
