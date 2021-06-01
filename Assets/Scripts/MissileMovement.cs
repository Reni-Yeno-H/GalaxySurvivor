using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMovement : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 25;
    public bool isSpecialBullet = false;
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
