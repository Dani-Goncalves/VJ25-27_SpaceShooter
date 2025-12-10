using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] float speed;

    void Start()
    {
        rb.linearVelocity =  Vector2.up * speed;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();

        if(enemy != null)
        {
            enemy.TakeDamage(1);
        }

        Destroy(gameObject);
    }
}
