using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawner : MonoBehaviour
{
    public int Respawn;
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("EnemyProjectile")){
            
            Destroy(gameObject);
            //lvlmanagers.instance.Respawn();
            SceneManager.LoadScene(Respawn);
        }
    }
}
