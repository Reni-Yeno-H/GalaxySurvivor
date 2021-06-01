using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleFlip : MonoBehaviour
{
    [SerializeField] Transform Player;
	[SerializeField] float speed; //= 10.0f;
	[SerializeField] bool isFacingRight = false;
    
    
    void Update()
    {
        if(Player != null){
        if (Player.transform.position.x < transform.position.x && isFacingRight || Player.transform.position.x > transform.position.x && !isFacingRight)
        {
			Flip();
        }
        }
    }
    void Flip()
	{
        isFacingRight = !isFacingRight;
		transform.Rotate(0f, 180f, 0f);
	}
}
