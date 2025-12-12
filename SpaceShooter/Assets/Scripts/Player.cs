using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

public class Player : Damageable
{
    [SerializeField] private float speed = 1;
    [SerializeField] private Bullet bullet;
    [SerializeField] private float pewpewRate = 1;
    [SerializeField] private int playerDamage = 1;
    Vector3 destination;

    void Start()
    {
        InvokeRepeating("PewPew", 0, pewpewRate);
    }
    void Update()
    {
        Movement();
    }
    void FixedUpdate()
    {
        Vector2 positionInBetween = Vector2.Lerp(transform.position, destination, speed*Time.fixedDeltaTime);

        transform.position = positionInBetween; // A e C retorna B
    }
    void PewPew()
    {
        Instantiate(bullet,transform.position,Quaternion.identity);

        Bullet newbullet = Instantiate(bullet, transform.position, Quaternion.identity);

        newbullet.SetDamage(playerDamage);
    }

    public void Increment(StatType stat)
    {
        if(stat == StatType.Damage)
        {
            playerDamage++;
        }
        if(stat == StatType.Speed)
        {
            
        }
        
    }
    void Movement()
    {
        Camera cam = Camera.main;

        if(Input.touchSupported && Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector3 worldPos = cam.ScreenToWorldPoint(new Vector3(
                touch.position.x,
                touch.position.y,
                cam.nearClipPlane));

            worldPos.z = transform.position.z;

            destination = worldPos;
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = cam.ScreenToWorldPoint(new Vector3(
                Input.mousePosition.x,
                Input.mousePosition.y,
                cam.nearClipPlane));
            
            mousePos.z = transform.position.z;

            destination = mousePos;
        } 
        else if (Input.GetMouseButton(0))
        {
            destination = Vector2.Lerp(transform.position, destination, speed*Time.fixedDeltaTime);
        }
    }

}
