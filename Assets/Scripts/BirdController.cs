using UnityEngine;
using UnityEngine.InputSystem;

public class BirdController : MonoBehaviour
{
    [SerializeField] private float speed = 1.5f;
    [SerializeField] private float rotationSpeed = 10f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            rb.linearVelocity = Vector2.up * speed;
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.linearVelocity.y * rotationSpeed);
    }

}
