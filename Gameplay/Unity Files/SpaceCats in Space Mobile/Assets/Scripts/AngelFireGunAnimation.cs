using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngelFireGunAnimation : MonoBehaviour
{
    //calling the animator myAnimator

    Animator myAnimator;

    // calling the fire anmation by its condition "shoot"

    const string FireAnimation = "shoot";


    // Start is called before the first frame update
    void Start()
    {

        myAnimator = GetComponent<Animator>();

    }


  
 

    void Update()
    {

        // when space is clcked

        if (Input.GetButtonDown("Fire1"))
        {

            // trigger "fireAnimation"

            myAnimator.SetTrigger(FireAnimation);

        }
    }
}
