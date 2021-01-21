using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowCharacter : MonoBehaviour
{
    // target that the camera is following

    public Transform target;

    // dampening on the camera

    public float smoothing;

    // difference between motion of character and motion of camera

    Vector3 offset;

    // lowest point our camera can go

    float lowY;

    float highY;



    // Start is called before the first frame update

    void Start()
    {
        offset = transform.position - target.position;

        lowY = transform.position.y;

        highY = transform.position.y;


    }

    // Update is called once per frame

    void FixedUpdate()
    {

        // if the target is not destroyed (Angel dies)


        if(target != null)
        {

            // aim position based on the offset

            Vector3 targetCamPos = target.position + offset;


            // lerp is easing, Vector 3 in xyz position with smoothing x time in seconds to commpllete the last frame

            transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);


            // telling camera to not go up or donwn off screen

            if (transform.position.y < lowY) transform.position = new Vector3(transform.position.x, lowY, transform.position.z);

            if (transform.position.y > highY) transform.position = new Vector3(transform.position.x, highY, transform.position.z);



        }

       

    }

   


}
