﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_6 : MonoBehaviour
{
    public float speed = .01f;
    public ParticleSystem explosionParticle;

    void Update()
    {
        if(Hero.S != null)
            transform.position = Vector3.Lerp(transform.position, Hero.S.gameObject.transform.position, speed*Time.deltaTime);   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponentInParent<Hero>() != null)
        {
            print("explode");
            Detonate();
            Destroy(gameObject);
        }
    }

    private void Detonate()
    {
        ParticleSystem explosionParticleClone = Instantiate(explosionParticle, transform.position, Quaternion.identity);
    }

    private void OnCollisionEnter(Collision coll)
    {
        GameObject otherGO = coll.gameObject;
        if(otherGO.tag == "ProjectileHero")
            Destroy(gameObject);

    }
}     
