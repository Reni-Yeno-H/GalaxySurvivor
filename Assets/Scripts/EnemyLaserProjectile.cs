using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserProjectile : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 25;
    //public bool isSpecialBullet = false;
    [SerializeField] bool isFacingRight = false;
    
    public Rigidbody2D rb;
    public GameObject playerImpactEffect;
    //Movement target;
    Vector2 moveDirection;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject alienShooter;
    //PlayerHealthSystem target;
    //public AudioSource firedAudio;
    public AudioSource PlayerGotHitAudio;
    public AudioSource PlayerDeathAudio;

    // Start is called before the first frame update
    void Start()
    {
        //rb.velocity = transform.right * speed;
        
        //  if (firedAudio == null)
        //       firedAudio = GetComponent<AudioSource>();
        
        rb = GetComponent<Rigidbody2D>();

        // if (firedAudio == null){
        //     firedAudio = GetComponent<AudioSource>();
        //     }
        
        
        Player = GameObject.FindGameObjectWithTag("Player");
        //target = GetComponent.FindObjectOfType<Movement>();
        // if (firedAudio == null){
        //     firedAudio = GetComponent<AudioSource>();
        //     }
        if(Player != null){
        moveDirection = (Player.transform.position - transform.position).normalized * speed;
        
        //moveDirection = (target.transform.position - transform.position).normalized * speed;
        //moveDirection = (target.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);

        // Debug.Log("pre");
        // if (firedAudio == null){
        //     Debug.Log("running?");
        //     firedAudio = GetComponent<AudioSource>();
        //     Debug.Log("running?");
        //     }
        //     Debug.Log("post");
        //rb.velocity = new Vector2.MoveTowards(transform.position,Player.transform.position,speed * Time.deltaTime);
        //Destroy (gameObject,3f);
        
        //if(Player.transform.position == null)
        //{
        //    rb = null;
        //}
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        
        PlayerHealthSystem player = hitInfo.GetComponent<PlayerHealthSystem>();
        if(player != null)// && player.playerHealth != 0)
        {
            
            //player.PlayerGotHitAudio();
            //player.playerDeathAudio(isSpecialBullet);
            Instantiate(playerImpactEffect,transform.position,transform.rotation);
            Destroy(gameObject);
            player.TakeDamage(damage);
        }
        //Instantiate(impactEffect,transform.position,transform.rotation);
        //Destroy(gameObject);
    }

    void Update()
    {
        if(Player != null){
        if (Player.transform.position.x < alienShooter.transform.position.x && isFacingRight || Player.transform.position.x > alienShooter.transform.position.x && !isFacingRight)
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
