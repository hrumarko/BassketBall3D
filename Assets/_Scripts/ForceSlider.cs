using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceSlider : MonoBehaviour
{
    public Slider sliderForce;
    

    void Update(){
        while(sliderForce.value != 0.12){
            sliderForce.value += 0.01f;
        }
    }
}
