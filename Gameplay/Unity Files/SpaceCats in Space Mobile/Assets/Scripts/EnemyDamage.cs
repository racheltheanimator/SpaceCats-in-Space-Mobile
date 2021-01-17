using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    // the amount of damage the enemy can do

    public float damage;

    //  the rate of dammage

    public float damageRate;

    // the force pushing character off the enemy

    public float pushBackForce;

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

            // pushing back the players transform

            pushBack(other.transform);
        }
    }


    void pushBack(Transform pushedObject)
    {

        // the vecor direction of the push is oposite from the object

        Vector2 pushDirection = new Vector2(0,(pushedObject.position.y - transform.position.y)).normalized;

        // multiply by pushback force

        pushDirection *= pushBackForce;

        // found rigid body of pushed object

        Rigidbody2D pushRB = pushedObject.gameObject.GetComponent<Rigidbody2D>();

        // all forces affecting payer are sert to zero

        pushRB.velocity = Vector2.zero;

        //  then we add the force as an explosive force

        pushRB.AddForce(pushDirection, ForceMode2D.Impulse);

    }


}
