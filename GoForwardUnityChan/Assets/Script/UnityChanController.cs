﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class UnityChanController : MonoBehaviour
{

    private float groundLevel = -3.0f;
    Animator animator;
    Rigidbody2D rigid2D;
    private float dump = 0.8f;
    private float jumpVelocity = 20;

    private float deadLine = -9;

    // Use this for initialization
    void Start()
    {
        this.animator = GetComponent<Animator>();

        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        this.animator.SetFloat("Horizontal", 1);

        bool isGround = (this.transform.position.y > groundLevel) ? false : true;
        this.animator.SetBool("isGround", isGround);

        GetComponent<AudioSource>().volume = (isGround) ? 1 : 0;


        if (Input.GetMouseButtonDown(0) && isGround)
        {
            this.rigid2D.velocity = new Vector2(0, this.jumpVelocity);

        }

        if (Input.GetMouseButton(0) == false)
        {
            if (this.rigid2D.velocity.y > 0)
            {
                this.rigid2D.velocity *= this.dump;
            }
        }


        if (transform.position.x < deadLine)
        {
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();

            Destroy(gameObject);
        }

    }
}
