﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 3;
    public float jump = 5;
    float vx = 0;
    bool leftflag = false;
    bool pushflag = false;
    bool jumpflag = false;
    bool grounflag = false;
    Rigidbody2D rbody;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        vx = 0;
        if (Input.GetKey("right"))
        {
            vx = speed;
            leftflag = false;
        }
        if (Input.GetKey("left"))
        {
            vx = -speed;
            leftflag = true;
        }
        if (Input.GetKeyDown("space") && grounflag)
        {
            if(pushflag == false)
            {
                jumpflag = true;
                pushflag = true;
            }
        }

        else
        {
            pushflag = false;
        }
}
     void FixedUpdate()
    {
        rbody.velocity = new Vector2(vx, rbody.velocity.y);
        this.GetComponent<SpriteRenderer>().flipX = leftflag;
        if (jumpflag)
        {
            jumpflag = false;
            rbody.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }

    }
    void OnTriggerStay2D(Collider2D collision)
    {
        grounflag = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        grounflag = false;
    }
}