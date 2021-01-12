using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //movement variables

    public float maxSpeed;

    Rigidbody2D myRB;

    Vector2 movement;



    // Use this for initialization

    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame, FixedUpdate is always called at a speciffic time

    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal"); movement.x = Input.GetAxis("Horizontal");

        myRB.velocity = new Vector2(move * maxSpeed, myRB.velocity.y);

    }


}

