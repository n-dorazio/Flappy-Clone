using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJumpScript : MonoBehaviour
{
    public Animator anim;
    public BirdScript crawly;
    // Start is called before the first frame update
    
 void Start()
    {
        crawly = GameObject.FindGameObjectWithTag("Crawly").GetComponent<BirdScript>();
    }


     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && crawly.birdIsAlive){
           anim.SetBool("Jump",true);
        }
        else{  
             anim.SetBool("Jump",false);
        }

        
    }
}
