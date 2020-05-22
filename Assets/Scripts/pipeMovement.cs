using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMovement : MonoBehaviour
{

    public float movement=2;
    void Update()
    {

        Vector3 newPos = gameObject.transform.position;

        newPos.x = newPos.x - movement*Time.deltaTime;

        gameObject.transform.position = newPos;
        
    }
    
}
