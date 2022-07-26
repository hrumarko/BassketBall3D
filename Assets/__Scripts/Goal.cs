using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    public TextMeshProUGUI texts;
    public TextMeshProUGUI textGoal;
    public AudioSource audioSrc;
    public static bool isGoal =false;
    public static bool isBonusGoal = false;
    int counts = 0;
    public static int deleteZombies;
    public Animator anim;
    public GameObject scoreText;
    public Animator animShake;
    
    
    
    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {   
        
        if(other.gameObject.tag == "Ball"){
            audioSrc.Play();
            
            if(!Achievement.isBonus){
                textGoal.text = "+1";
                
                anim.SetBool("isBasic", true);
                animShake.SetBool("isGoalAnim", true);
                StartCoroutine(AnimationCoroutine());
                isGoal = true;
                counts++;
                texts.text = counts.ToString();
            }

            if(Achievement.isBonus){
                textGoal.text = "+3";
                anim.SetBool("isBonus", true);
                animShake.SetBool("isGoalAnim", true);
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
        animShake.SetBool("isGoalAnim", false);
        anim.SetBool("isBonus", false);
        anim.SetBool("isBasic", false);
        textGoal.text = "";
    }
}
