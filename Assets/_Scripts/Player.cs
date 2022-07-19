using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField] float _speed = 10f;
    bool isConducting = false;
    
    public Transform basketPos;
    public Transform conductingPos;
    public Transform resetBallPos;
    public Transform throwPos;
    
    public GameObject ballPrefab;
    Rigidbody ballRb;
    Rigidbody rb;
    float forceThrow =20f;
    [Range (0, 0.12f)]public float force;
    
    private void Awake() {
        ballRb = ballPrefab.gameObject.GetComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
    }
    
    private void Update() {
        
        Moving();

        if(isConducting){
            Conducting();
            if(Input.GetKeyDown(KeyCode.F)){
                isConducting = false;
                ballPrefab.transform.position = resetBallPos.position;
            }
            if(Input.GetKeyDown(KeyCode.Space)){
                isConducting = false;
                Throw();
            }
        }      
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ball"){
            isConducting = true;
        }
    }
    void Moving(){
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(-x,  0, -z);
        if(direction.magnitude > Mathf.Abs(0.1f))
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime*10f);
        rb.velocity = direction * _speed;
    }

    

    void Throw(){
        ballPrefab.transform.position = throwPos.position;
        transform.LookAt(new Vector3(-0.12f, 0.37f, -11.72f));
        ballPrefab.GetComponent<Rigidbody>().isKinematic = false;
        Vector3 forceVector =  ((basketPos.transform.position - ballPrefab.transform.position)+ new Vector3(0, forceThrow, 0));
        ballRb.AddForce(forceVector * (1+ force), ForceMode.Impulse);
    }

    void Conducting(){
        
        ballPrefab.GetComponent<Rigidbody>().isKinematic = true;
        ballPrefab.transform.position = conductingPos.position + Vector3.up * Mathf.Abs(Mathf.Sin(Time.time*5));
    }


    

    

    
    

    
}
