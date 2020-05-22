using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float flyForce=200f;
    void Awake(){

        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){

            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(0,flyForce));
        }
    }
}
