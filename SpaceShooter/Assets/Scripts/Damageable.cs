using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] private int health =3;

    public void TakeDamage(int damage)
    {
        health -= damage;

        print(gameObject + " levou " + damage + " dano");

        if(health<=0)
        {
            Destroy(gameObject);
        }
    }
    
}
