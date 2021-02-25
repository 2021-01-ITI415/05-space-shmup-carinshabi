using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_5 : Enemy
{
    public int shootForce = 1000;
    public float shootDelay = 1;
    public float shootInterval = 3;
    public GameObject basicProjectilePrefab;

    private void Start()
    {   
        //Start function runs 1 time every time the object is enabled or comes alive.

        InvokeRepeating("Shoot", 2, 2);
    }

    private void Update()
    {
        if (bndCheck != null && bndCheck.offDown)
        {
            Destroy(gameObject);
        }

        //All "Update" functions called one timer per "frame", like a still image in a movie or animation.

        //Calling the base move function from the base class "Enemy"
        base.Move();
    }

    private void Shoot()
    {       
        //Create a new instance of the projectile game object.
        GameObject basicProjectileClone = Instantiate(basicProjectilePrefab);
        basicProjectileClone.transform.position = transform.position;
        basicProjectileClone.GetComponent<Rigidbody>().AddForce(new Vector3(0, shootForce * -1, 0));
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


