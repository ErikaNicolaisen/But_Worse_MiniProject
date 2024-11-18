using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentMover : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    void Update()
    {
        if (PlayerHealth.isPlayerAlive)
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
    }
}
