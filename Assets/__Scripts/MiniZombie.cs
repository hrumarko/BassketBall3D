using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniZombie : MonoBehaviour
{   
    public float speed;
    Rigidbody rb;
    public GameObject particles;
    public AudioClip sound;
    public AudioClip soundOfRun;
    public AudioSource audioSrc;
    public static bool isBoom = false;
    void Start(){
        rb = GetComponent<Rigidbody>();
        audioSrc.PlayOneShot(soundOfRun);
        if(transform.position.x < 0){
            Vector3 direction = new Vector3(36, 0, Random.Range(-13, 10));
            rb.velocity = direction * speed;
        }

        Destroy(this.gameObject, 3f);
        
    }

    

    
    
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player"){
            HealthManager.health -= 1;
            isBoom = true;
            audioSrc.Stop();
            GameObject go = Instantiate(particles, this.gameObject.transform.position, Quaternion.identity );
            Destroy(go, 1f);
            Destroy(this.gameObject);
            
            
            
        }

        if(other.gameObject.tag == "Tree" || other.gameObject.tag == "Zombie" || other.gameObject.tag == "Ball"){
            isBoom = true;
            audioSrc.Stop();
            
            
            GameObject go = Instantiate(particles, this.gameObject.transform.position, Quaternion.identity );
            Destroy(go, 1f);
            Destroy(this.gameObject);
        }
    }
}
