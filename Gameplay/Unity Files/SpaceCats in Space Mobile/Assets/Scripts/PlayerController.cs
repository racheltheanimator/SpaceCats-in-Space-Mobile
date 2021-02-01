using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    

    //movement variables

    public float maxSpeed;

    Rigidbody2D myRB;

    Vector2 movement;

    //setting recoil

    [HideInInspector]
    public Vector2 recoil = Vector2.zero;




    // Use this for initialization

    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();

    }


    // Update is called once per frame

    void Update ()
    {
     
    }




    // FixedUpdate is always called at a speciffic time

    void FixedUpdate()
    {

        // Angel movement, rigidbody velocity is movement vector for x and y x maxspeed

        float x = Input.GetAxis(("Horizontal") * maxSpeed+recoil.x, rigidbody2D.velocity.y+recoil.y);
        float y = Input.GetAxis("Vertical");

        myRB.velocity = new Vector2(x, y)*maxSpeed; }







}

