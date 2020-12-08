using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 5f;

    public Animator animator;
    public Rigidbody2D rb;

    Vector2 movement;
    Vector2 mousePosition;

  
    public GameObject shot;

    public Camera cam;

    bool facingRight = true;
    void Update()
    { 

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Speed", Mathf.Abs(movement.x));

        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        
    }

    void FixedUpdate()
    {   //Allows the user to move
        rb.MovePosition(rb.position+ movement * speed * Time.fixedDeltaTime);
        
        if(movement.x< 0 && facingRight)
        {
            flip();
        }
        else if (movement.x>0 && !facingRight)
        {
            flip();
        }


    }

    void flip()
    {// Flips the sprite when going the other way
        facingRight = !facingRight;
        transform.Rotate(0f,180f,0f);
    }
}
