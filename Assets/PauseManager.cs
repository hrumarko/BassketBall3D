using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject canvasPause;

    public void Pause(){
        Time.timeScale = 0;
        canvasPause.SetActive(true);
    }

    public void Resume(){
        Time.timeScale = 1;
        canvasPause.SetActive(false);
    }
}
