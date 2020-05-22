using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    private Rigidbody2D rb;

    private bool isDead;

    public float flyForce = 200f;
    public float forwardForce = 100f;
    void Awake()
    {

        rb = GetComponent<Rigidbody2D>();
        isDead = false;
    }

    void Update()
    {
        if (!isDead)
        {
            if (Input.GetMouseButtonDown(0))
            {

                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0, flyForce));
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        isDead = true;
    }
}
