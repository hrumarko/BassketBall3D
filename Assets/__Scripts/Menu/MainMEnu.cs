using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMEnu : MonoBehaviour
{

    public GameObject shop;
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

    public void OpenShop(){
        shop.SetActive(true);
    }
    public void CloseShop(){
        shop.SetActive(false);
    }

}
