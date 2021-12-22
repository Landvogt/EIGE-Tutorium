using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bomb : MonoBehaviour
{

    public float speed;
    public bool invincible;
    public float bumpSpeed;
    Rigidbody rb;

    
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector3(speed, rb.velocity.y, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("End"))
        {
            speed *= -1;
        }
    }

    public void OnDeath()
    {
        gameObject.GetComponent<Collider>().enabled = false;
    }
}


