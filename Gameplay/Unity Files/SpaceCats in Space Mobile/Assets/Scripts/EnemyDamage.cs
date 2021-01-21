using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

 

    // the amount of damage the enemy can do

    public float damage;

    //  the rate of dammage

    public float damageRate;

    // when can the next damage be done

    float nextDamage;

   
        





    // Start is called before the first frame update
    void Start()
    {

        // next damage to the character can occur imediattley

        nextDamage = 0f;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // when the player stays on the enemy collider

    void OnTriggerStay2D(Collider2D other)
    {
        // when the tag is player and the next damage is less than the current time


        if(other.tag=="Player" && nextDamage < Time.time)
        {

            // getting the AngelHealth script

            AngelHealth thePlayerHealth = other.gameObject.GetComponent<AngelHealth>();

            // thePlayerHealth = addDamage from the AngelHealth script

            thePlayerHealth.addDamage(damage);

            // the next damage is time + damage rate

            nextDamage = Time.time + damageRate;

            
           
        }


    }

   



}
