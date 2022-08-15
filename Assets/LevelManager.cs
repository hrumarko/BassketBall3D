using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static int numberOfLevel;
    public static int curentScore;
    public GameObject gameOverCanvas;
    void Start()
    {
        numberOfLevel = PlayerPrefs.GetInt("numberOfLevel", numberOfLevel);
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
            gameOverCanvas.SetActive(true);
            
        }
    }
}
