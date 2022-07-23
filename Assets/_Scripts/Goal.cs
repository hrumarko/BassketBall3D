using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    public TextMeshProUGUI texts;
    public static bool isGoal =false;
    public static bool isBonusGoal = false;
    int count = 0;
    public static int deleteZombies;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball"){
            isGoal = true;
            count++;
            texts.text = count.ToString();

            if(Achievement.isBonus){
                deleteZombies = FindObjectOfType<Achievement>().count;
                isBonusGoal = true;
                Debug.Log("BONUS!!!!");
                
                count += 5;
                texts.text = count.ToString();
                Achievement.isBonus = false;
                
            }
        }
    }
}
