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
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        myRB.velocity = new Vector2(x, y)*maxSpeed; }

       



 


}

