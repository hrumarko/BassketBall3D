using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    public TextMeshProUGUI texts;
    public static bool isGoal =false;
    int count = 0;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball"){
            isGoal = true;
            count++;
            texts.text = count.ToString();
        }
    }
}
