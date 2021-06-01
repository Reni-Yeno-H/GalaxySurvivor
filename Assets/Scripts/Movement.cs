using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	[SerializeField] Vector2 movement;
	[SerializeField] Rigidbody2D rigid;
	[SerializeField] float speed = 20.0f;
	[SerializeField] bool isFacingRight = true;
	//[SerializeField] float jumpForce = 50.0f;
	//[SerializeField] LayerMask whatIsGround;
	//[SerializeField] float groundDistance = 1.5f;
    //[SerializeField] bool grounded;
	[SerializeField] Animator anim;
	//public bool speedingDown = false;
	//public bool returnNormalSpeed = false;
	//public int touchCounter = 0;
	//public float slowRate = 0.5f;
	//public float nextSlowness = 0.0f;
	//public bool isCoroutineExecuting = false;
	//public float delayTime = 2.5f;

	const int idle = 0;
	const int speedUp = 1;
	const int backAway = -1;
	
	//public GameObject ScoreBoard;

	//public Transform firePoint;
    //public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
		if (rigid == null)
			rigid = GetComponent<Rigidbody2D>();
		if(anim == null)
			anim = GetComponent<Animator>();
			anim.SetInteger("motion", idle);
		
		
    }

    // Update is called once per frame; good for user input
    void Update()
    {
		//slowDown.x = Input.GetAxisRaw("Horizontal");
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

		//if(Input.GetKeyDown(KeyCode.LeftShift) && touchCounter == 1) //&& Time.time > nextSlowness)
		//{
			//nextSlowness = Time.time + slowRate;
		//	anim.SetInteger("motion", backAway);
		//	speedingDown = true;
		//	returnNormalSpeed = false;
		//}

		//if(Input.GetKeyDown(KeyCode.LeftShift) && touchCounter == 2) 
		//{
			
		//	anim.SetInteger("motion", speedUp);
		//	speedingDown = false;
		//	returnNormalSpeed = true;
		//	touchCounter = 0;
		//}
		
		//if (Input.GetKeyDown(KeyCode.Return)){
        //    Instantiate(projectile, firePoint.position, firePoint.rotation);
		//}
    }

    //called potentially multiple times per frame, best for physics for smooth behavior
    void FixedUpdate()
	{

		//rigid.velocity = new Vector2(movement * speed, rigid.velocity.y);
		
		rigid.MovePosition(rigid.position + movement * speed * Time.fixedDeltaTime);

		//if(speedingDown)
		//{//anim.SetInteger("motion", backAway);
		//tapCount();
		//speed = 5.0f;
		
		//}

		//if(returnNormalSpeed)
		//{//anim.SetInteger("motion", backAway);
		//tapCount();
		//speed = 20.0f;
		
		//}


		if(movement.x > 0.1 || movement.x < -0.1)
			anim.SetInteger("motion", speedUp);
			
		//else if(movement.x < 0 && isFacingRight || movement.x > 0 && !isFacingRight)
			//anim.SetInteger("motion", backAway);
			else
			anim.SetInteger("motion", idle);
			 

		//if (movement.x > Time.time)
			//anim.SetInteger("motion", backAway);
		
		if (movement.x < 0 && isFacingRight || movement.x > 0 && !isFacingRight)
			//anim.SetInteger("motion", backAway);
			//Flip();
			//anim.SetInteger("motion", backAway);
			//if(movement.x && Time.time > nextFlip)
			//WaitToFlip(delayTime);
			
			//ExecuteAfterTime();
			Flip();
			
			//StartCoroutine(WaitToFlip(delayTime));
	}

	//public int tapCount(){
	//	if(Input.GetKeyDown(KeyCode.LeftShift))
	//	touchCounter++;
	//}

	//void slowDown(){
	//	Vector2 speedDown = new Vector2(10f, rb.velocity.y);
	//	rb.velocity = speedDown; 

	//}

	//IEnumerator WaitToFlip(float delayTime)
	//{
	//		if(isFacingRight == true)
	//		isFacingRight = false;
			//print(Time.time);
			//if (movement.x < 0 && isFacingRight || movement.x > 0 && !isFacingRight)
	//		yield return new WaitForSeconds(delayTime);

	//		if(isFacingRight == false)
	//		isFacingRight = true;

	//		yield return new WaitForSeconds(delayTime);
			//Flip();
			//print(Time.time);
	//}

	void Flip()
	{
		//Vector3 playerScale = transform.localScale;
		//playerScale.x = playerScale.x * -1;
		//transform.localScale = playerScale;

        //transform.Rotate(0, 180, 0);

        isFacingRight = !isFacingRight;
		transform.Rotate(0f, 180f, 0f);
	}

    //void Jump()
	//{
	//	if (isOnGround())
	//	{
	//		rigid.velocity = new Vector2(rigid.velocity.x, 0);
	//		rigid.AddForce(new Vector2(0, jumpForce));
	//	}
	//}

    //bool isOnGround()
	//{
	//	Debug.Log("is on ground called");
	//	Vector2 position = transform.position;
	//	Vector2 direction = Vector2.down;

		//for debugging purposes only
	//	Debug.DrawRay(position, direction, Color.green);

	//	Debug.Log("drew ray");

	//	RaycastHit2D hit = Physics2D.Raycast(position, direction, groundDistance, whatIsGround);
	//	if (hit.collider != null)
	//		grounded = false;
	//	else
	//		grounded = true;
	//	return grounded;
            
	//}
}
