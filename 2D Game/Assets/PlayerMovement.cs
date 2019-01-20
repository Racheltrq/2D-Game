﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public float speed;
    private float accelation;
    private Rigidbody2D player;
    private float prev_speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal;
        float moveVertical = 0;
        float moveHorizontal_raw = Input.GetAxis("Horizontal");
        float moveVertical_raw = Input.GetAxis("Vertical");

        if (moveHorizontal_raw >= 0) { 
            if (prev_speed <= moveHorizontal_raw)
            {
                if (moveHorizontal_raw > 0) moveHorizontal = 1;
                else moveHorizontal = 0;
            }
            else
            {
                moveHorizontal = 0;
            }
            
        }
        else
        {
            if (prev_speed >= moveHorizontal_raw)
            {
                if (moveHorizontal_raw < 0) moveHorizontal = -1;
                else moveHorizontal = 0;
            }
            else
            {
                moveHorizontal = 0;
            }
        }
        prev_speed = moveHorizontal_raw;
        if (moveVertical_raw > 0)
        {
            moveVertical = 1.2f;
        };

        animator.SetFloat("speed", Mathf.Abs(moveHorizontal));
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        player.AddForce(movement * speed);
        movement.x = Mathf.Clamp(player.position.x, -0.5f, 15);
        //player.AddForce(transform.up * speed);
    }
}
