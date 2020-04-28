using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Ruby : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer sprite;
    public BoxCollider2D collider;

    [SerializeField]
    private float moveSpeed;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        collider = GetComponent<BoxCollider2D>();


    }
    // Update is called once per frame
    void Update()      
    {
        //if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            //Move Left
            animator.SetBool("RunSide",true);
            animator.SetBool("RunDown", false);
            animator.SetBool("RunUp", false);
            sprite.flipX = false;
            transform.position = new Vector2(transform.position.x - moveSpeed, transform.position.y);
        }
        
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            //Move right
            animator.SetBool("RunSide", true);
            animator.SetBool("RunDown", false);
            animator.SetBool("RunUp", false);
            sprite.flipX = true;
            transform.position = new Vector2(transform.position.x + moveSpeed, transform.position.y);
        }
       
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            // Move Down
            animator.SetBool("RunDown", true);
            animator.SetBool("RunSide", false);
            animator.SetBool("RunUp", false);
            transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed);
        }
        
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            // Move Up
            animator.SetBool("RunUp", true);
            animator.SetBool("RunDown", false);
            animator.SetBool("RunSide", false);
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed);
        }
    }
}
