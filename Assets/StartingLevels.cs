using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StartingLevels : MonoBehaviour
{
    public Animator startLevels;
    public TextMeshProUGUI levelsText;

    void Awake(){
        levelsText.text = "LEVEL  " + LevelManager.numberOfLevel;
    }
    void Start(){
        startLevels.SetBool("startLevel", true);
    }

}
