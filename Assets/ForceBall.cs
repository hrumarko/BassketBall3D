using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceBall : MonoBehaviour
{
    public Slider slider;
    public float time;

    void Update(){
        if(Input.GetKeyDown(KeyCode.P)){
            slider.value = 0f;
            StartCoroutine(ForceSlider());
            
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            StopAllCoroutines();

        }
    }

    public IEnumerator ForceSlider(){
        
            
            while(true){
                StartCoroutine(Help());
                yield return new WaitForSeconds(0.5f);
            }
        
        

    }
    public IEnumerator Help(){
        if(slider.value <= 0f){
                    while(slider.value != 0.12f){
                        slider.value += 0.01f;
                        yield return new WaitForSeconds(time);
                    }
                    
                }
                
                if(slider.value >= 0.12f){
                    Debug.Log("AAAAAAAAA");
                    while(slider.value != 0f){
                        slider.value -= 0.01f;
                        yield return new WaitForSeconds(time);
                    }
                }
    }
}
