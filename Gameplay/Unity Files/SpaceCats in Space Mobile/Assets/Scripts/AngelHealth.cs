using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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


    //HUD Variables

    public Slider healthSlider;


    // Start is called before the first frame update
    void Start()
    {
        // current health is equal to full health

        currentHealth = fullHealth;

        // getting the PlayerController script

        controlMovement = GetComponent<PlayerController>();

        //HUD initilization

        healthSlider.maxValue = fullHealth;

        // new HUD value is all the way full

        healthSlider.value = fullHealth;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //if damage is added


    public void addDamage(float damage)
    {
        if (damage<= 0) return;

        //when current health is equal to current health minus damage

        currentHealth -= damage;

        // get angel flash red aimation

        gameObject.GetComponent<Animation>().Play("angelFlashRed");


        // ajust health slider to show damage

        healthSlider.value = currentHealth;



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
