using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextOnEnemy : MonoBehaviour
{
    [SerializeField] Transform enemy;
	[SerializeField] float speed = 10.0f;
    
    
    void Update()
    {
        if(enemy != null){

        transform.position = Vector2.MoveTowards(transform.position,enemy.transform.position,speed * Time.deltaTime);
        
        }
    }
    
}
