using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngelGunshotHit : MonoBehaviour
{

    //how much damage the gunshon does to enemies

    public float weaponDamage;

    // calling the projectile controlller script myPC

    AngelGunshotProjectileCotroller myPC;

    // the angel gunshot hit particle prefab

    public GameObject AngelGunshotHitPrefab;




    // Start is called before the first frame update
    void Awake()
    {

        //get the script from the current object called AngelGunshotProjectileController


        myPC = GetComponent<AngelGunshotProjectileCotroller>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onTriggerEnter2d(Collider2D other)

        //if object is set to layer name "shootable"
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("shootable"))
        {

            //stops  the gunshot

            myPC.removeForce();

            //take current position and initiate GunshotHit

            Instantiate(AngelGunshotHitPrefab, transform.position, transform.rotation);

            //destroyes the gunshot

            Destroy(gameObject);
        }
    }


    //safeguard if bullet is going too fast to make contact

    void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.layer == LayerMask.NameToLayer("Shootable"))
        {

            //stops  the gunshot

            myPC.removeForce();

            //take current position and initiate GunshotHit

            Instantiate(AngelGunshotHitPrefab, transform.position, transform.rotation);

            //destroyes the gunshot

            Destroy(gameObject);
        }
    }

}
