using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaMovement : MonoBehaviour
{
    public float speed = 5f;
    public int damage = 50;
    public bool isSpecialBullet = true;
    public Rigidbody2D rb;
    public AudioSource FiredAudio;
    public GameObject impactEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
            
            if (FiredAudio == null){
            FiredAudio = GetComponent<AudioSource>();
            }
    }
    
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy != null)
        {
            
            enemy.TakeDamage(damage,isSpecialBullet);
            //Destroy(gameObject);
            enemy.enemyHitAudio(isSpecialBullet);
            enemy.enemyDeathAudio(isSpecialBullet);
            Instantiate(impactEffect,transform.position,transform.rotation);
        Destroy(gameObject);
        }
        //Instantiate(impactEffect,transform.position,transform.rotation);
        //Destroy(gameObject);
    }
}
