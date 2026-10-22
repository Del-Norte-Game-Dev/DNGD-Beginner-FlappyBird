using UnityEngine;
using UnityEngine.InputSystem;

public class BirdController : MonoBehaviour
{
    [SerializeField] private float speed = 1.5f;
    [SerializeField] private float rotationSpeed = 10f;

    [SerializeField] private Animator anim;

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
            anim.SetTrigger("jump");
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.linearVelocity.y * rotationSpeed);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Obstacles")
        {
            Time.timeScale = 0f;
        }
    }

}
