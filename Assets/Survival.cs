using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Survival : MonoBehaviour
{
    // Start is called before the first frame update
   public void StartSurvival(){
            Time.timeScale = 1;        
            LevelManager.numberOfLevel = 0;
            PlayerPrefs.SetInt("numberOfLevel", 0);
            SceneManager.LoadScene(1);
   }
}
