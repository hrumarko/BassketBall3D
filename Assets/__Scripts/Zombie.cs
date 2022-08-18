using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    GameObject player;
    bool isDamage = true;
    Rigidbody rb;
    public float t;
    bool isHarder0 = false;
    bool isHarder1 = false;
    bool isHarder2 = false;
    public Animator damageAnim;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isHarder0 && Goal.counts > 15){
            isHarder0 = true;
            Debug.Log("Ебеееем");
            t += 2f;
        }

        if(!isHarder1 && Goal.counts > 45){
            isHarder0 = true;
            t += 2f;
        }

        if(!isHarder2 && Goal.counts > 75){
            isHarder0 = true;
            t += 2f;
        }
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
                StartCoroutine(Damage());
                HealthManager.health -= 1;
                Debug.Log("-1 HP");
            }
        }
    }

    public IEnumerator ZombieDamageKooldown(){
        
        yield return new WaitForSeconds(1f);
        isDamage = true;
    }

    public IEnumerator Damage(){
        // damageAnim.SetBool("isDamage", false);
        damageAnim.SetBool("isDamage", true);
        yield return new WaitForSeconds(1f);
        damageAnim.SetBool("isDamage", false);
    }
}
