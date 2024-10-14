using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{

    public LogicScript logic;
    public BirdScript crawly;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        crawly = GameObject.FindGameObjectWithTag("Crawly").GetComponent<BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){

        if(collision.gameObject.layer == 3 && crawly.birdIsAlive){
        logic.addScore(1);
        }

    }
}
