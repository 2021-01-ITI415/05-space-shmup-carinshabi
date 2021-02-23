using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_5 : Enemy
{
    public GameObject basicProjectilePrefab;

    private void Start()
    {   
        //Start function runs 1 time every time the object is enabled or comes alive.

        InvokeRepeating("Shoot", 2, 2);
    }

    private void Update()
    {
        if (bndCheck.offDown)
            Destroy(gameObject);
        

        //All "Update" functions called one timer per "frame", like a still image in a movie or animation.

        //Calling the base move function from the base class "Enemy"
        base.Move();
    }

    private void Shoot()
    {
        //Puts a comment in the console.
        Debug.Log("Shoot");

        //Create a new instance of the projectile game object.
        GameObject basicProjectileClone = Instantiate(basicProjectilePrefab);
        basicProjectileClone.transform.position = transform.position;
        basicProjectileClone.GetComponent<Rigidbody>().AddForce(new Vector3(0, -1000, 0));
    }
}

//INHERITANCE

//Class Fruit
//public int color;
//public int calories;

//Strawbery : Fruit
//public int seeds

//FUNCTION PERAMTERS
//public void BakeACake()
//{
//  stir 10 minutes;
//  add 1 ounce of water
//  cook 5 minutes
//}

//public void BakeACake(int minutesToCook, int ouncesOfWater, int cookTime)
//{
//  stir minutesToCook minutes;
//  add ouncesOfWater ounce of water
//  cookcookTime minutes
//}

//BakeACake();
//BakeACake(22, 3, 20);

//TODO

//Fix bound box to let enemy go off screen.
//Make projectile a laser.
//Make projectile shoot towards the player.
//Make the enemy look at the player.

