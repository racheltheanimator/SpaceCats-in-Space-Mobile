using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngelGun : MonoBehaviour
{

    // referencce to gun Angel's gun muzzle object

    public Transform gunMuzzle;




    // referencce to Angel's gunshot prefab

    public GameObject angelGunshotProjectile;
   

    // Update is called once per frame


    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();

        }
    }

    void Shoot()
    {
        // shooting logic. Spawn Angel's gunshot prefab at the gun muzzle object

        Instantiate(angelGunshotProjectile, gunMuzzle.position, gunMuzzle.rotation);

    }
}
