using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceBall : MonoBehaviour
{
    public Slider slider;
    public float time;
    public static float forces;
    public static bool isForce = false;
    int countValue = 0;
    bool isRight = true;

    void Start(){
        
    }
    private void FixedUpdate()
    {
        if(isForce){
            if(countValue == 0){
                countValue = 1;
                
                slider.value =0;
                
            }
            StartCoroutine(Help());

            
       
        }
    }

    public void StartForceSlider(){
        slider.value = 0f;
        StartCoroutine(ForceSlider());
    }
    public void GetValueForce(){
        // countValue = 0;
        forces = slider.value;
        StopAllCoroutines();
        
    }

    public IEnumerator ForceSlider(){
            while(true){
                StartCoroutine(Help());
                yield return new WaitForSeconds(0.2f);
            }        
    }
    public IEnumerator Help(){
        while(isForce){
            if(isRight){
                slider.value += 0.01f * time;
                // yield return new WaitForSeconds(0.1f);
                if(slider.value >=0.11f){
                    isRight = false;
                }
            }

            if(!isRight){
                slider.value -= 0.01f * time;
                // yield return new WaitForSeconds(0.1f);
                if(slider.value <= 0.01f){
                    isRight = true;
                }
            }
            yield return new WaitForSeconds(7f);
        }
    }
}
