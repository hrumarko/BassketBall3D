using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public Transform player;
    Rigidbody rb;
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = player.position.x;
        float z = player.position.z;
        
        Vector3 direction = new Vector3(x-transform.position.x, 0.7060078f, z - transform.position.z);
        direction.Normalize();
        rb.velocity = direction * t; 
    }
}
