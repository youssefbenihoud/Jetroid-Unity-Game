using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public float speed = 150f;
    public Vector2 maxVelocity = new Vector2(60, 100);
    public float jetSpeed = 200f;
    public float airSpeedMultiplier = 0.3f;
    public bool standing;
    public float standingThreshold = 4f;


    private Rigidbody2D rigidbody;
    private SpriteRenderer renderer;
    private Animator anim;
    private PlayerControllerScript controller;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
        controller = GetComponent<PlayerControllerScript>();
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
       
    }


    private void Move()
    {
        var absVelX = Mathf.Abs(rigidbody.velocity.x); 
        var absVelY = Mathf.Abs(rigidbody.velocity.y);
        standing = (absVelY <= standingThreshold) ? true : false;

        var forceX = 0f;
        var forceY = 0f;

        Debug.Log("absVelY = " + absVelY + " / absVelX = "+ absVelX); // Debug for Testing


        if (controller.GetMoving().x != 0)
        {
            if (absVelX < maxVelocity.x)
            {
                var newSpeed = speed * controller.GetMoving().x;
                forceX = standing ? newSpeed : (newSpeed * airSpeedMultiplier);


                renderer.flipX = forceX < 0;
            }
            anim.SetInteger("AnimState", 1);
        }
        else
        {
            anim.SetInteger("AnimState", 0);
        }


        if (controller.GetMoving().y > 0)
        {
            if (absVelY < maxVelocity.y)
            {
                forceY = jetSpeed*controller.GetMoving().y;
                
            }
            anim.SetInteger("AnimState", 2);
        }
        else if (absVelY > 0 && !standing)
        {
            anim.SetInteger("AnimState", 3);
        }

        rigidbody.AddForce(new Vector2(forceX, forceY));
    }// Move Method








}//Class
