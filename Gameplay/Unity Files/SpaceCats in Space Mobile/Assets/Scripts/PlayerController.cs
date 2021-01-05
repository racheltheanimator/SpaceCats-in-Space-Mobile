using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //movement variables

    public float maxSpeed;

    public Rigidbody2D myRB;

    Vector2 movement;


    //for shooting

    public Transform gunTip;
    public GameObject bullet;
    float fireRate = 0.5f;
    float nextFire = 0f;


    // Start is called before the first frame update

    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }


    //player shooting

    if(Input.getAxis("Fire1")>0) fireGun();
}

    void FixedUpdate()
    {


        myRB.MovePosition(myRB.position + movement * maxSpeed * Time.fixedDeltaTime);
    }
}

void fireGun()
{

if(Time.time > nextFire)
    {
        nextFire = Time.time + fireRate;


    }

}