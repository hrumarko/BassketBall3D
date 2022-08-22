using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiedMenu : MonoBehaviour
{   
    
    public GameObject canvas;
    public void MainMenu(){
        canvas.SetActive(false);
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void Restart(){
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        LevelManager.countCall = 0;
        Goal.counts =0;
        Game.money = 0;
        
        
        PlayerPrefs.SetInt("numberOfLevel", LevelManager.numberOfLevel);
        HealthManager.health = 3;
    }

    public void WatchAdd(){

        //watchadd
        Time.timeScale = 1;
        HealthManager.health = 3;
        SceneManager.LoadScene(1);
    }
    public void A(){
        transform.parent.gameObject.SetActive(false);
    }
}
