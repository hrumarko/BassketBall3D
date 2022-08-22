using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMainMenu : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioSource musicAudioSrc;
    int rand;

    void Start(){
        rand = Random.Range(0, clips.Length);
        musicAudioSrc.PlayOneShot(clips[rand]);
    }
}
