using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniZombie : MonoBehaviour
{   
    public float speed;
    Rigidbody rb;
    void Start(){
        rb = GetComponent<Rigidbody>();
        
        if(transform.position.x < 0){
            Vector3 direction = new Vector3(36, 0, Random.Range(-13, 10));
            rb.velocity = direction * speed;
        }
    }
}
