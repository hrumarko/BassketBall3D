using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimManager : MonoBehaviour
{
    bool isAnimPlay = false;
    
    int count = 0;
    
    Animator animPlayer;


    private void Start()
    {   
        animPlayer = GetComponent<Animator>();
        
    }



    private void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        
            if(Mathf.Abs(x) >0f || Mathf.Abs(z) >0f ){
                
                isAnimPlay = true;
                if(isAnimPlay && count ==0){
                animPlayer.SetBool("isRun", true);
                
                count = 1;
        }
            
            } else{
                count = 0;
                animPlayer.SetBool("isRun", false);
                isAnimPlay = false;
                
            }

        
        
    }   
}
