using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngelGunshotProjectileCotroller : MonoBehaviour
{
    public float gunshotSpeed;

    Rigidbody2D myRB;


    // Start is called before the first frame update
    void Awake()
    {
        myRB = GetComponent<Rigidbody2D>();

        myRB.AddForce(new Vector2(1,0) * gunshotSpeed, ForceMode2D.Impulse);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
