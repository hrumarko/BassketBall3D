using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    public TextMeshProUGUI texts;
    int count = 0;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball"){
            Debug.Log("GOALLLL!!!!!!!!!!!!!!!! SIIIIUUUUUUUUUUUUUU");
            count++;
            texts.text = count.ToString();
        }
    }
}
