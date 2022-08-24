using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StartingLevels : MonoBehaviour
{
    public Animator startLevels;
    public TextMeshProUGUI levelsText;

    void Awake(){
        if(LevelManager.numberOfLevel == 0){
            levelsText.text = "SURVIVAL";
        } else{
            levelsText.text = "LEVEL  " + LevelManager.numberOfLevel;
        }
    }
    void Start(){
        startLevels.SetBool("startLevel", true);
        Time.timeScale = 1;
    }

}
