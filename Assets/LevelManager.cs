using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    int numberOfLevel;
    public static int curentScore;
    public GameObject gameOverCanvas;
    void Start()
    {
        if(numberOfLevel == 1){
            curentScore = 9;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Goal.counts >= curentScore){
            //StopGame();
            Time.timeScale = 0;
            
        }
    }
}
