using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    GameObject player;
    bool isDamage = true;
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
        
        
        Vector3 direction = new Vector3(x-transform.position.x, 0, z - transform.position.z);
        direction.Normalize();
        rb.velocity = direction * t;
        
        if(direction.magnitude > Mathf.Abs(0f))
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime*10f);
        
         
    }


    private void OnCollisionEnter(Collision other)
    {
        if(isDamage){
            if(other.gameObject.tag == "Player"){
                isDamage = false;
                StartCoroutine(ZombieDamageKooldown());
                HealthManager.health -= 1;
                Debug.Log("-1 HP");
            }
        }
    }

    public IEnumerator ZombieDamageKooldown(){
        
        yield return new WaitForSeconds(1f);
        isDamage = true;
    }
}
