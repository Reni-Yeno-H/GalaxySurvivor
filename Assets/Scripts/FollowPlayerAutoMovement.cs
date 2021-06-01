using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerAutoMovement : MonoBehaviour
{
    [SerializeField] Transform Player;
	[SerializeField] float speed = 10.0f;
	[SerializeField] bool isFacingRight = false;
    
    
    void Update()
    {
        if(Player != null){

        if (Player.transform.position.x < transform.position.x && isFacingRight || Player.transform.position.x > transform.position.x && !isFacingRight)
        {
			Flip();
        }
        transform.position = Vector2.MoveTowards(transform.position,Player.transform.position,speed * Time.deltaTime);
        
        }
    }
    void Flip()
	{
        isFacingRight = !isFacingRight;
		transform.Rotate(0f, 180f, 0f);
	}
   
}
