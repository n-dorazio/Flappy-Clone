using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{

    public GameObject cloud;
    public float spawnRate = 1;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate){
            timer = timer + Time.deltaTime;
        }
        else{
            spawnCloud();
            timer = 0;
        }
        
    } 
       void spawnCloud(){
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(cloud, new Vector3(transform.position.x,Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
