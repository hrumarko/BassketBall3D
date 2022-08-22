using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioButton : MonoBehaviour
{
    public AudioSource audioSrc;
    public AudioClip clip;

    public void PlayClip(){
        audioSrc.PlayOneShot(clip);
        
    }
}
