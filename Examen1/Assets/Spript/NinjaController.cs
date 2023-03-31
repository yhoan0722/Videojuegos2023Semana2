using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaController : MonoBehaviour
{
    private int currentAnimation = 1;
    private Animator animator;
    Rigidbody2D rb;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
        rb.velocity = new Vector2(0,rb.velocity.y);
         currentAnimation = 1;
        if(Input.GetKey(KeyCode.X))
        {
            currentAnimation = 4;
            rb.velocity = new Vector2(5,rb.velocity.y);
            
                  
        }
        if(Input.GetKey(KeyCode.Y))
        {
            currentAnimation = 6;
            rb.velocity = new Vector2(5,rb.velocity.y);
           
                       
        }
        
       
        animator.SetInteger("Estado",currentAnimation);
    }
}
