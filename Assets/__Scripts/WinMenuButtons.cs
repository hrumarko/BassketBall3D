using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextLevel(){
        
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        LevelManager.countCall = 0;
        Goal.counts =0;
        Game.money = 0;
        LevelManager.numberOfLevel += 1;
        PlayerPrefs.SetInt("numberOfLevel", LevelManager.numberOfLevel);
        HealthManager.health = 3;
    }

    public void Restart(){

        SceneManager.LoadScene(1);
        Game.money = 0;
        LevelManager.countCall = 0;
        Goal.counts =0;
        
        
        PlayerPrefs.SetInt("numberOfLevel", LevelManager.numberOfLevel);
        HealthManager.health = 3;
    }

    public void Menu(){
        SceneManager.LoadScene(0);
    }
}
