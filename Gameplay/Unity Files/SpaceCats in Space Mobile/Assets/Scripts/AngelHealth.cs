using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AngelHealth : MonoBehaviour
{

    // full health of character

    public float fullHealth;

    // curent health of character

    float currentHealth;

    //game object is Angel Explosion clled DeathFX

    public GameObject deathFX;

    // Player Controller script called controlMovement

    PlayerController controlMovement;

    //HUD Variables

    public Slider healthSlider;

    // HUD damage screen for when angel gets hurt

    public Image damageScreen;

    // HUD bool for on / off damage

    bool damaged = false;

    // damage screen color and alpha

    Color damagedColor = new Color(0f, 0f, 0f, 0.4f);

    // smoothing animatin of damage screen coor

    float smoothColor = 5f;






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

        // damaged is false

        damaged = false;

    }

    // Update is called once per frame
    void Update()
    {

        // if Angel is Damaged, show the damage screen at full color

        if (damaged)
        {
            damageScreen.color = damagedColor;
        }

        /// animation of screen alpha

        else
        {
            damageScreen.color = Color.Lerp(damageScreen.color, Color.clear, smoothColor*Time.deltaTime); 
        }

        // tur damage back to false / alpha is 0

        damaged = false;


    }


    //if damage is added


    public void addDamage(float damage)
    {
        if (damage<= 0) return;

        //when current health is equal to current health minus damage

        currentHealth -= damage;

        // damaged is true

        damaged = true;

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
