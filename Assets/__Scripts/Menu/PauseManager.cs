using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public GameObject canvasPause;
    public AudioMixerGroup mixer;
    public Slider musicSlider;
    public Slider soundsSlider;
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    private void Update()
    {
        mixer.audioMixer.SetFloat("MusicVolume",musicSlider.value);
        mixer.audioMixer.SetFloat("SoundsVolume",soundsSlider.value);
    }
    public void Pause(){
        Time.timeScale = 0;
        canvasPause.SetActive(true);
    }

    public void Resume(){
        Time.timeScale = 1;
        canvasPause.SetActive(false);
    }

    public void Restart(){
        Time.timeScale = 1;
        HealthManager.health = 3;
        SceneManager.LoadScene(1);
        canvasPause.SetActive(false);
    }

    public void MainMenu(){
        SceneManager.LoadScene(0);
    }
}
