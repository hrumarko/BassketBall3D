using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    GameObject player;
    Rigidbody rb;
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = player.transform.position.x;
        float z = player.transform.position.z;
        
        Vector3 direction = new Vector3(x-transform.position.x, 0.7060078f, z - transform.position.z);
        direction.Normalize();
        rb.velocity = direction * t; 
    }


    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player"){
            HealthManager.health -= 1;
            Debug.Log("-1 HP");
        }
    }
}
