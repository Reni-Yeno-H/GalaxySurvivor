using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int enemyNum;
    public GameObject deathEffect;
    public GameObject Plane;
    public Transform firePoint;
    //public int Score = 0;
    public AudioSource EnemyHitAudio;
    public AudioSource EnemyDeathAudio;
    public AudioSource EnemySpecialHitAudio;
    public AudioSource EnemySpecialDeathAudio;
    public int touchDamage;
    //bool isSpecialBullet;
    //public Animator anim;
    //public GameObject ScoreBoard;

    void Start()
    {
        if (Plane == null)
            Plane = GameObject.FindGameObjectWithTag("Player");
    }


    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerHealthSystem playerHealth = hitInfo.GetComponent<PlayerHealthSystem>();
        if(hitInfo.gameObject.tag == "Player"){
        //Healthbar health = transform.GetComponent<HealthBar>();//there can be a problem with the script
        //Healthbar is name of last sript
            //PlayerHealthSystem playerHealth = hitInfo.GetComponent<PlayerHealthSystem>();
            if (playerHealth != null){
            playerHealth.TakeDamage(touchDamage);
            //TakeDamage it is a void in HealthBar script
            }
        }
    }

    public void TakeDamage(int damage, bool isSpecialBullet)
    {
       health -= damage;

        if(health >= 0)
        {
            enemyHitAudio(isSpecialBullet);
        //if (EnemyHitAudio == null)
            //EnemyHitAudio = GetComponent<AudioSource>();
            //AudioSource.PlayClipAtPoint(EnemyHitAudio.clip, transform.position);
        }else {
            //if (EnemyDeathAudio == null)
            //EnemyDeathAudio = GetComponent<AudioSource>();
            //AudioSource.PlayClipAtPoint(EnemyDeathAudio.clip, transform.position);
            //killed();
            enemyDeathAudio(isSpecialBullet);
            //Die(isSpecialBullet);
            Die();
            Plane.GetComponent<Score>().IncrementScore();
        }
    }
    
    //void killed()
    //{
    //    anim.SetBool("isDestroyed",true);
    //}
    public void enemyHitAudio(bool isSpecialBullet){
        if(isSpecialBullet == false)
        {
            if (EnemyHitAudio == null)
            EnemyHitAudio = GetComponent<AudioSource>();
            AudioSource.PlayClipAtPoint(EnemyHitAudio.clip, transform.position);
            
        } else {
            
            if (EnemySpecialHitAudio == null)
            EnemySpecialHitAudio = GetComponent<AudioSource>();
            AudioSource.PlayClipAtPoint(EnemySpecialHitAudio.clip, transform.position);
            
        } 
    }

    public void enemyDeathAudio(bool isSpecialBullet){

        if(isSpecialBullet == false)
        {
            if (EnemyDeathAudio == null)
            EnemyDeathAudio = GetComponent<AudioSource>();
            AudioSource.PlayClipAtPoint(EnemyDeathAudio.clip, transform.position);
        } else {
            if (EnemySpecialDeathAudio == null)
            EnemySpecialDeathAudio = GetComponent<AudioSource>();
            AudioSource.PlayClipAtPoint(EnemySpecialDeathAudio.clip, transform.position);
        }
    }

    public void Die()
    {
        
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        //anim.SetBool("isDestroyed",true);
        //StartCoroutine(deathDelay());
        //Destroy(gameObject,2f);
        Destroy(gameObject);
        
    }

    //IEnumerator deathDelay(){

      //  yield return new WaitForSeconds(1f);
      //  Destroy(gameObject);
    //}

    //void Start()
    //{
        //if (controller == null)
            //controller = GameObject.FindGameObjectWithTag("GameController");
        //if (audio == null)
        //    audio = GetComponent<AudioSource>();
        
    //}
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //if (collision.gameObject.tag == "Projectile")
    //   {
    //        Debug.Log("Target Hit!");
    //        ScoreBoard.GetComponent<Score>().IncrementScore();
    //        AudioSource.PlayClipAtPoint(audio.clip, transform.position); //figure out if that is the best way of handling audio source/clip
            //Destroy(gameObject);


    //    }
    //}
}

