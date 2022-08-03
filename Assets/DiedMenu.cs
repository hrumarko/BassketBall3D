using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiedMenu : MonoBehaviour
{   
    
 
    public void MainMenu(){
        SceneManager.LoadScene(0);
    }

    public void Restart(){
        Time.timeScale = 1;
        HealthManager.health = 3;
        SceneManager.LoadScene(1);
        A();
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
