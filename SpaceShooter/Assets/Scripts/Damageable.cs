using System;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] private int health =3;

    [SerializeField] private GameObject explosion;

    public void TakeDamage(int damage)
    {
        health -= damage;

        print(gameObject + " levou " + damage + " dano");

        if(health<=0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
        if(explosion!=null)
        {
            GameObject explosionInstance = Instantiate(explosion,transform.position,Quaternion.identity);
        
            Destroy(explosionInstance, 1);
            
        }
    }
}
