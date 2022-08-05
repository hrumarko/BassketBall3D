using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMEnu : MonoBehaviour
{

    public void StartGame(){
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void StopGame(){
        Application.Quit();
    }

    public void AddMoney(){
        MoneyManager.Money += 10;
    }


}
