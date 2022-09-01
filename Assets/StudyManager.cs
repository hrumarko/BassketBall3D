using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StudyManager : MonoBehaviour
{
    public GameObject[] scenes;
    int countOfClick = 0;
    public Button[] buttons;
    int isFirstLogin =0;



    void Start(){
        isFirstLogin = PlayerPrefs.GetInt("isFirstLogin");
        if(isFirstLogin == 0)
        {
            //PlayerPrefs.DeleteAll();
            for(int i = 0; i < buttons.Length; i++){
            buttons[i].interactable = false;
            
        }
        scenes[0].SetActive(true);
        }
    }
    void Update(){
        if(isFirstLogin == 0){
            if(Input.GetMouseButtonDown(0) && countOfClick == 0){
            
            scenes[0].SetActive(false);
            scenes[1].SetActive(true);
            countOfClick++;
            
            }else if(countOfClick == 1 && Input.touchCount == 0){
                countOfClick++;
            }
            else if(Input.GetMouseButtonDown(0) && countOfClick == 2){
            
            scenes[1].SetActive(false);
            scenes[2].SetActive(true);
            countOfClick++;
            
            }
            else if(countOfClick == 3 && Input.touchCount == 0){
                countOfClick++;
            }else if(Input.GetMouseButtonDown(0) && countOfClick == 4){
            
            scenes[2].SetActive(false);
            scenes[3].SetActive(true);
            countOfClick++;
            
            }
            else if(countOfClick == 5 && Input.touchCount == 0){
                countOfClick++;
            }else if(Input.GetMouseButtonDown(0) && countOfClick == 6){
            
            scenes[3].SetActive(false);
            scenes[4].SetActive(true);
            countOfClick++;
            
            }
            else if(countOfClick == 7 && Input.touchCount == 0){
                countOfClick++;
            }else if(Input.GetMouseButtonDown(0) && countOfClick == 8){
            
                scenes[4].SetActive(false);
                countOfClick++;
                for(int i = 0; i < buttons.Length; i++){
                    buttons[i].interactable = true;
                    isFirstLogin = 1;
                    PlayerPrefs.SetInt("isFirstLogin", isFirstLogin);
                    countOfClick++;

                }    
                
            }

        

        
        }

        
    }
}
