using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtr : MonoBehaviour
{
    // Main Player Controller ................................IT15099600
    public float Playerspeed;
    public float jumpForce = 35f;

    //private bool isJumping;
    private float move;
    private Rigidbody2D rb;
    private Animator anim;

    public AudioSource pickupSound;

    public GameObject deadExplosion;

  


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();           
        }

        move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(move * Playerspeed, rb.velocity.y);

        if (move < 0)
        {
            transform.eulerAngles = new Vector3(0, -180, 0);

        }
        else if (move > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            
        }

        RunAnimaion();
    }
	
	//coin and fruit collection objects destroy
	private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("coins"))
        {
            Destroy(other.gameObject);

            pickupSound.Play();
        }


        if (other.gameObject.CompareTag("jems"))
        {
            Destroy(other.gameObject);
            
            pickupSound.Play();
        }


        if (other.gameObject.CompareTag("Life"))
        {
            Destroy(other.gameObject);

            pickupSound.Play();
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            dead();
        }



    }

    void Jump()
    {
        Vector2 jump = new Vector2(rb.velocity.x, jumpForce);

        rb.velocity = jump;
        
    }

    //Animation
    void RunAnimaion()
	{
        anim.SetFloat("PlayerAnimation", Mathf.Abs(move));
        //anim.SetBool("isJumping", isJumping );
	}


    //dead

    void dead()
    {
        Instantiate(deadExplosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }


    
    
    }
