using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMiniZombies : MonoBehaviour
{
    public GameObject zombieMini;
    public AudioSource audioSrc;
    public AudioClip clip;
    int countCor = 0;

    void Update(){
        if(MiniZombie.isBoom == true){
            MiniZombie.isBoom =false;
            audioSrc.PlayOneShot(clip);
        }

        if(Goal.counts > 20 && countCor ==0){
            countCor = 1;
            StartCoroutine(SpawnZombies());
        }
    }

    public IEnumerator SpawnZombies(){
        while(true){
            Instantiate(zombieMini, new Vector3(-19.43f,0,0), Quaternion.identity);
            yield return new WaitForSeconds(7f); 
        }
        
    }
}
