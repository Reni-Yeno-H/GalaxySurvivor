using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondaryWeapon : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject secondaryPlasmaGun;
    public GameObject specialAttackSpark;
    public AudioSource secondaryGunAudio;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            
            Shoot();
        }
    }


//shooting logic

void Shoot()
{
    Instantiate(specialAttackSpark, firePoint.position, firePoint.rotation);
    if (secondaryGunAudio == null){
            secondaryGunAudio = GetComponent<AudioSource>();
            }
    Instantiate(secondaryPlasmaGun, firePoint.position, firePoint.rotation);
    //Destroy(specialAttackSpark);
}
}
