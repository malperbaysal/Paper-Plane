using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public ParticleSystem explosionParticle;
    public GameObject bullet;
    public bool isMoving;
    void Update()
    {
        if (isMoving)
        {
            transform.position+=transform.forward * (Time.deltaTime * 50);   
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Terrain"))
        {
            Explosion();
        }
    }

    void Explosion()
    {
        bullet.SetActive(false);
        
        explosionParticle.Play();
        
        isMoving = false;
    }
}
