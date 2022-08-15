using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMEnu : MonoBehaviour
{

    public GameObject shop;
    public GameObject zombieCoin;

    public GameObject settings, ad;
    
    RectTransform rt;
    void Start(){
        rt = zombieCoin.GetComponent<RectTransform>();
    }
    public void StartGame(){
        SceneManager.LoadScene(1);
        HealthManager.health = 3;
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
        
        
        rt.anchoredPosition = new Vector3(-1726,-101,0);
        settings.SetActive(false);
        ad.SetActive(false);
    }
    public void CloseShop(){
        rt.anchoredPosition = new Vector3(-619,-101,0);
        settings.SetActive(true);
        ad.SetActive(true);
        shop.SetActive(false);
    }

}
