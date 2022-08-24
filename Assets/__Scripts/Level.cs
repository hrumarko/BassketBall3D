using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public int numOfLevel;
    public bool isLevelClosed;
    public int countStar;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public Animator animLocked;
    public AudioSource audioSourceLevel;
    public AudioClip error;
    


    void Start(){
        countStar = StarsOfLevel.LevelStars[numOfLevel];
        SetStars(countStar);
        if(numOfLevel != 1){
            if(StarsOfLevel.LevelStars[numOfLevel-1] <2){
                isLevelClosed = true;
                
            }else{
                isLevelClosed = false;
                animLocked.SetBool("isLocked", false);
            }
        }
    }
    public void PlayLevel(){
        if(!isLevelClosed){
            Time.timeScale = 1;        
            LevelManager.numberOfLevel = numOfLevel;
            PlayerPrefs.SetInt("numberOfLevel", numOfLevel);
            SceneManager.LoadScene(1);
        }else{
            StartCoroutine(LockedAnim());
            audioSourceLevel.PlayOneShot(error);
        }
    }
    void SetStars(int countStar){

        if(countStar == 3){
            star1.GetComponent<Image>().color = new Color(255, 255, 255, 255);
            star2.GetComponent<Image>().color = new Color(255, 255, 255, 255);
            star3.GetComponent<Image>().color = new Color(255, 255, 255, 255);
            
        }

        if(countStar == 2){
            star1.GetComponent<Image>().color = new Color(255, 255, 255, 255);
            star2.GetComponent<Image>().color = new Color(255, 255, 255, 255);
            
        }

        if(countStar == 1){
            star1.GetComponent<Image>().color = new Color(255, 255, 255, 255);
            
        }
    }
    public IEnumerator LockedAnim(){
        animLocked.SetBool("isLocked", true);
        yield return new WaitForSeconds(1f);
        animLocked.SetBool("isLocked", false);
    }
}
