using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;

    public float timeBetweenPipes = 0.5f;

    public float maxHeight=2;
    public float minHeight=-2;
    
    public void Start()
    {
         InvokeRepeating ("SpawnPipes", 1.0f, timeBetweenPipes);
    }


    void SpawnPipes(){

        float y = UnityEngine.Random.Range (minHeight, maxHeight);
        float x = gameObject.transform.position.x;

        Instantiate (pipePrefab, new Vector3(x,y,0), Quaternion.identity);

    }

    
}
