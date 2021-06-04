using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float Playerspeed;
    public float jumpForce = 35f;

    //private bool isJumping;
    private float move;
    private Rigidbody2D rb;
    private Animator anim;

  //  public AudioSource pickupSound;

   // public GameObject deadExplosion;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
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
            transform.eulerAngles = new Vector2(0,1);

        }
        else if (move > 0)
        {
            transform.eulerAngles = new Vector2(0, 1);
        }
        RunAnimaion();
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

}
