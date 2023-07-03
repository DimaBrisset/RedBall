using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private float Speed;
    [SerializeField] private float JumpSpeed;

    private float HorizontalInput;

    private bool Jumping;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        rb.velocity=new Vector2(HorizontalInput*Speed,rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space)&& !Jumping)
        {
            Jump();
        }
    }

    public void Jump()
    {
        rb.AddForce(Vector2.up*JumpSpeed);
        Jumping = true;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Jumping = false;
        }
    }
}
