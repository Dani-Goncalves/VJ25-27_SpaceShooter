using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] float speed = 1;
    [SerializeField] private int damage = 1;

    void Start()
    {
        rb.linearVelocity =  Vector2.up * speed;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Damageable enemy = collision.gameObject.GetComponent<Enemy>();

        if(enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        Destroy(gameObject);
    }

    public void SetDamage(int newDamage)
    {
        damage = newDamage;
    }
}
