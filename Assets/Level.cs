using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public int numOfLevel;

    public int countStar;

    public void PlayLevel(){
        Time.timeScale = 1;
        LevelManager.numberOfLevel = numOfLevel;
        PlayerPrefs.SetInt("numberOfLevel", numOfLevel);
        SceneManager.LoadScene(1);

    }
    void Update(){
        this.gameObject.SetActive(false);
    }
}
