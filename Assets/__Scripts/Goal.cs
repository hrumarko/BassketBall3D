using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    public TextMeshProUGUI texts;
    public TextMeshProUGUI textGoal;

    public static bool isGoal =false;
    public static bool isBonusGoal = false;
    int counts = 0;
    public static int deleteZombies;
    public Animator anim;
    public GameObject scoreText;
    
    
    
    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {   
        
        if(other.gameObject.tag == "Ball"){
            
            
            if(!Achievement.isBonus){
                textGoal.text = "+1";
                
                anim.SetBool("isBasic", true);
                StartCoroutine(AnimationCoroutine());
                isGoal = true;
                counts++;
                texts.text = counts.ToString();
            }

            if(Achievement.isBonus){
                textGoal.text = "+3";
                anim.SetBool("isBonus", true);
                StartCoroutine(AnimationCoroutine());
                isGoal = true;
                deleteZombies = FindObjectOfType<Achievement>().count;
                isBonusGoal = true;
                
                
                counts += 3;
                texts.text = counts.ToString();
                Achievement.isBonus = false;
                
            }
        }
    }

    public IEnumerator AnimationCoroutine(){
        yield return new WaitForSeconds(0.5f);
        anim.SetBool("isBonus", false);
        anim.SetBool("isBasic", false);
        textGoal.text = "";
    }
}
