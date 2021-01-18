using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundaries : MonoBehaviour
{



    // namnig vector2 screenBounds


    private Vector2 screenBounds;


    // Start is called before the first frame update
    void Start()
    {

        // gives us an x and y value thats half of the world value in unnits


        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // math to calvulate the screen position and clamp


        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x, screenBounds.x * -1);
        transform.position = viewPos;
    }
}
