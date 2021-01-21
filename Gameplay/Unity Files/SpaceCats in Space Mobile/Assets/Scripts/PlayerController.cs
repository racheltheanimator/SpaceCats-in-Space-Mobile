using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // making this script and instace (for other scripts)

    public static PlayerController instace;


    //movement variables

    public float maxSpeed;

    Rigidbody2D myRB;

    Vector2 movement;









    // naming the instance of this script "this" (for other scripts)

    private void Awake()
    {
        instace = this;
    }



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

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        myRB.velocity = new Vector2(x, y)*maxSpeed; }





    // knockback code



    public IEnumerator Knockback(float knockbackDuration, float knockbackPower, Transform obj)
    {
        float timer = 0;

        while (knockbackDuration > timer)
        {
            timer += Time.deltaTime;
            Vector2 direction = (obj.transform.position - this.transform.position).normalized;
            myRB.AddForce(-direction * knockbackPower);
        }

        yield return 0;

    }



}

