using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject primaryWeapon;
    public GameObject firedSpark;
    public AudioSource FiredAudio;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            //if (FiredAudio == null){
            //FiredAudio = GetComponent<AudioSource>();
            //}
            Shoot();
        }
    }


//shooting logic
void Shoot()
{
    //Debug.Log("Shoot");
    Instantiate(firedSpark, firePoint.position, firePoint.rotation);
    if (FiredAudio == null){
            FiredAudio = GetComponent<AudioSource>();
            }
    Instantiate(primaryWeapon, firePoint.position, firePoint.rotation);
    //DestroyImmediate(firedSpark, true);
}

}