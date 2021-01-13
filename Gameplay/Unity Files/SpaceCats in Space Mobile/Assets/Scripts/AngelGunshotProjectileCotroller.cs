using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngelGunshotProjectileCotroller : MonoBehaviour
{

    // setting gunshot speed

    public float gunshotSpeed = 20f;

    // setting Rigidbody2D and naming it myRB

    public Rigidbody2D myRB;


    // Start is called before the first frame update

    void Start()
    {

        // the velocity of myRB = transform to the right x gunshot speed

        myRB.velocity = transform.right * gunshotSpeed;

      
    }

   
}



