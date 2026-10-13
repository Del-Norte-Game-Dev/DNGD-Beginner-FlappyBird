using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;

    void Start()
    {
        rb.linearVelocity = new Vector2(-speed, 0);
    }
}
