using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
    public Rigidbody myRigidbody;
    [SerializeField] private float velocity = 5;
    bool jump;
    Vector2 look;
    private float lookX;
    Camera mainCamera;
    [SerializeField] float speed = 0.01f;
    public Animator animator;

    private void Update()
    {
        if(jump)
        {
            Jump();
            jump = false;
        }

        Look();
    }

    void OnJump(InputValue value)
    {
        if(value.isPressed && !jump)
        {
            jump = true;
        }

        if(animator != null)
        {
            animator.SetBool("isFlapping", true);
        }
    }

    void OnLook(InputValue value)
    {
        look = value.Get<Vector2>();
        lookX = look.x;
    }

    void Look()
    {
        mainCamera = FindAnyObjectByType<Camera>();
        mainCamera.transform.Rotate(Vector3.up * lookX * speed);
    }

    void Jump()
    {
        if(jump)
        {
            myRigidbody.velocity = Vector3.up * velocity;
        }

        if(animator != null)
        {
            StartCoroutine(ResetFlapAnimation());
        }
    }

    private IEnumerator ResetFlapAnimation()
    {
        yield return new WaitForSeconds(0.2f);
        if (animator != null)
        {
            animator.SetBool("isFlapping", false);
        }
    }
}