using UnityEngine;

public class GroundLooper : MonoBehaviour
{
    [SerializeField] private float scrollSpeed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private SpriteRenderer sr;

    float tileLength;

    void Awake()
    {
        tileLength = sr.sprite.bounds.size.x;
    }
    void Update()
    {
        rb.linearVelocity = new Vector2(-scrollSpeed, 0);
        if (rb.transform.position.x < -tileLength)
        {
            rb.transform.Translate(new Vector2(tileLength, 0));
        }
    }
}
