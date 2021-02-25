using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicProjectile : MonoBehaviour
{
    //Get the player object to reference the position
    public ParticleSystem explosionParticle;

    private void Start()
    {
        Destroy(gameObject, 5);
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, .1f * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponentInParent<Hero>() != null)
        {
            Detonate();
            DamageHero();
            Destroy(gameObject);
        }
    }

    private void DamageHero()
    {
        if (Hero.S.shieldLevel > 0)
            Hero.S.shieldLevel--;
        else
            Destroy(gameObject);
    }

    private void Detonate()
    {
        ParticleSystem explosionParticleClone = Instantiate(explosionParticle, transform.position, Quaternion.identity);
    }
}
