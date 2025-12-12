using System.Data;
using Unity.VisualScripting;
using UnityEngine;

public class DamageBooster : MonoBehaviour
{
    [SerializeField] StatType type;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();

        if(player != null)
        {
            player.Increment(type);

            Destroy(gameObject);
        }
    }
}

public enum StatType
{
    Damage,

    Speed        
}
