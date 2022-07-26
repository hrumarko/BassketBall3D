using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioManager : MonoBehaviour
{
    bool isAudioPlay = false;
    bool isAudioStop = false;
    public Joystick joystick;
    int count = 0;
    AudioSource audioSrc;
    // Animator animPlayer;


    private void Start()
    {   
        // animPlayer = GetComponent<Animator>();
        audioSrc = GetComponent<AudioSource>();
    }



    private void Update()
    {

        float x = joystick.Horizontal;
        float z = joystick.Vertical;

        
            if(Mathf.Abs(x) >0f || Mathf.Abs(z) >0f ){
                
                isAudioPlay = true;
                if(isAudioPlay && count ==0){
                // animPlayer.SetBool("isRun", true);
                audioSrc.Play();
                count = 1;
        }
            
            } else{
                count = 0;
                // animPlayer.SetBool("isRun", false);
                isAudioPlay = false;
                audioSrc.Stop();
            }

        
        
    }
}
