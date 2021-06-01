using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enemyScore : MonoBehaviour
{
    
    [SerializeField] Text enemyText;
    public GameObject enemyPlane;
    // Start is called before the first frame update
    void Start()
    {
        DisplayEnemyHealth();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayEnemyHealth();
    }


    public void DisplayEnemyHealth()
    {
        int enemyNumber = enemyPlane.GetComponent<Enemy>().enemyNum;
        int enemyHealth = enemyPlane.GetComponent<Enemy>().health;
        // Debug.Log(playerHealth + "abc");
        // Debug.Log("before");
        enemyText.text = "Alien#" + enemyNumber + " HP: " + enemyHealth;
        // Debug.Log("after");
    }
}
