using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovementScript : MonoBehaviour
{

    public float moveSpeed;
    public float deadZone = -30;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = Random.Range(6,10);
    }

    // Update is called once per frame
    void Update()
    {
         transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        
        if(transform.position.x < deadZone){
            Debug.Log(transform.position.x);
            Debug.Log("Cloud Deleted");
            Destroy(gameObject);
        }
        
    }
}
