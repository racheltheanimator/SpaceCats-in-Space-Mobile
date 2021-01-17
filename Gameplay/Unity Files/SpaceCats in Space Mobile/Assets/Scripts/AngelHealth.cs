using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngelHealth : MonoBehaviour
{

    // full health of character

    public float fullHealth;

    //game object is Angel Explosion clled DeathFX

    public GameObject deathFX;

    // curent health of character

    float currentHealth;

    // Player Controller script called controlMovement


    PlayerController controlMovement;


    // Start is called before the first frame update
    void Start()
    {
        // current health is equal to full health

        currentHealth = fullHealth;

        // getting the PlayerController script

        controlMovement = GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addDamage(float damage)
    {
        if (damage<= 0) return;

        //current health is equal to current health minus damage

        currentHealth -= damage;

        // if current health is 0 or less, make dead

        if (currentHealth <= 0)
        {
            makeDead();
        }
    }


    // make dead instantiates DeathFX at players location

    public void makeDead()
    {
        Instantiate(deathFX, transform.position, transform.rotation);

        // destroys player

        Destroy(gameObject);

    }


}
