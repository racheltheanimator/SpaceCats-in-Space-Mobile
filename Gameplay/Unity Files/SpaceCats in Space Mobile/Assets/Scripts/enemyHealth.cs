using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{



    // max health the enemy can have


    public float enemyMaxHealth;


    //game object is called EnemyDeathFX

    public GameObject EnemydeathFX;


    // current health of the enemy

    float currentHealth;

   



    // Start is called before the first frame update

    void Start()
    {
        // enemy's current health equals the max health

        currentHealth = enemyMaxHealth;


    }

    // Update is called once per frame
    void Update()
    {

    }

    // add damage to the current health


    public void addDamage(float damage)

    {
        // changing health to be current health - damage

        currentHealth -= damage;

        // if current heallth is at zero, make the enemy dead

        if (currentHealth <= 0) makeDead();

        // if current heallth is at zero, play gem explode


        
    }


   


    void makeDead()
    {


        // play gem explosio effect


        Instantiate(EnemydeathFX, transform.position, transform.rotation);


        // destroy enemy


        Destroy(gameObject);


        // animation, sound, drop somethiing goes here




    }




}
