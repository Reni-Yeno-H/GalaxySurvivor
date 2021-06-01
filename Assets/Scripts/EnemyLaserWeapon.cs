using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserWeapon : MonoBehaviour
{
    [SerializeField] GameObject laser;
    public Transform firePoint;
    public GameObject firedSpark;
    //public bool alienAutoFireHardMode;
    //public AudioSource alienAutoFireHardMode;   //For hardMode
    //[SerializeField] GameObject AlienProjectile;
    //public bool soundOfFire = false;
    //PlayerHealthSystem player;
    float fireRate;// = 2f;
    float nextFire;// = Time.time;

    // Start is called before the first frame update
    void Start()
    {
         fireRate = 2f;
         nextFire = Time.time;    
         
        // if(player != false)
        
        // Respawn();
        // else
        // Respawn();
    }

    // void Respawn()
    // {
    //     CheckIfTimeToFire();
    //     //Instantiate(firedSpark, firePoint.position, Quaternion.identity);
    //     GameObject AlienProjectile = Instantiate(laser, firePoint.position, Quaternion.identity);
    // }

    //Update is called once per frame
    void Update()
    {
        
       CheckIfTimeToFire();//player);
    }

     void CheckIfTimeToFire()//PlayerHealthSystem hitInfo)
     {
        //player = hitInfo.GetComponent<PlayerHealthSystem>();
        //if(firedAudio == null)
        //    firedAudio = GetComponent<AudioSource>();
        if(Time.time > nextFire)//player.playerHealth != 0)
        //if(player != false)
        
        
        //if (alienAutoFireHardMode == null)   //For hardMode
        //    alienAutoFireHardMode = GetComponent<AudioSource>();   //For hardMode
             
        {    
            Instantiate(firedSpark, firePoint.position, Quaternion.identity);
            // if (firedAudio == null){
            //     Debug.Log("pre");
            // firedAudio = GetComponent<AudioSource>();
            // Debug.Log("running?");
            // }
            //Debug.Log("post");
            //Respawn();
            //nextFire = Time.time + fireRate;
            
            Instantiate(laser, firePoint.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
          
        }

    }
}
