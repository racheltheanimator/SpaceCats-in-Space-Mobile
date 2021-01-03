using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //movement variables

    public float maxSpeed;

    public Rigidbody2D myRB;

    Vector2 movement;


    // Start is called before the first frame update

    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }


    void FixedUpdate()
    {


        myRB.MovePosition(myRB.position + movement * maxSpeed * Time.fixedDeltaTime);
    }
}
