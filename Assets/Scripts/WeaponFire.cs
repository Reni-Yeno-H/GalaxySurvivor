using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFire : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject projectilePrefab2;
    //public Animator fireAnim;
    //int lifeTime = 1;
    //public static bool canBlink = false;
    // Update is called once per frame
    //void Start()
  //{
      //fireAnim = gameObject.GetComponent<Animator>();
  //}

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))// && (canBlink = false))
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
          //fireAnim.Play("fireSpark");
            fireball();
            
        }
        //projectilePrefab2.active = false;
        //projectilePrefab2.SetActive(false);
    }


//shooting logic
void fireball()
{
    //if (Input.GetButtonDown("Fire1")) {
    //projectilePrefab2.active = true;
   //}
    //canBlink = true;
    //projectilePrefab2.SetActive(true);
    //yield WaitForSeconds(destroyTime);
    
    Instantiate(projectilePrefab2, firePoint.position, firePoint.rotation);
    
    //Destroy(projectilePrefab2);
    
}

}

