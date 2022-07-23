using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    public TextMeshProUGUI texts;
    public static bool isGoal =false;
    public static bool isBonusGoal = false;
    int counts = 0;
    public static int deleteZombies;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball"){
            isGoal = true;
            counts++;
            texts.text = counts.ToString();

            if(Achievement.isBonus){
                deleteZombies = FindObjectOfType<Achievement>().count;
                isBonusGoal = true;
                Debug.Log("BONUS!!!!");
                
                counts += 5;
                texts.text = counts.ToString();
                Achievement.isBonus = false;
                
            }
        }
    }
}
