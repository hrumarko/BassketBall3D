using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    public TextMeshProUGUI texts;
    public TextMeshProUGUI textGoal;
    AudioSource audioSrc;
    public static bool isGoal =false;
    public static bool isBonusGoal = false;
    int counts = 0;
    public static int deleteZombies;
    public Animator anim;
    public GameObject scoreText;
    public Animator animShake;
    public int highScore;
    public TextMeshProUGUI highScoreText;
    
    
    
    private void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore", highScore);
        highScoreText.text = $"HIGHSCORE - {highScore}";
        audioSrc = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {   
        
        if(other.gameObject.tag == "Ball"){
            audioSrc.Play();
            
            if(!Achievement.isBonus){

                NotBonusGoal();
                
            }

            if(Achievement.isBonus){
                BonusGoal();
                
            }

            if(counts > highScore){
                highScore = counts;
                highScoreText.text = $"HIGHSCORE - {highScore}";
                PlayerPrefs.SetInt("highScore", highScore);
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

    void NotBonusGoal(){
                textGoal.text = "+1";
                
                anim.SetBool("isBasic", true);
                animShake.SetBool("isGoalAnim", true);
                StartCoroutine(AnimationCoroutine());
                isGoal = true;
                counts++;
                texts.text = counts.ToString();
    }

    void BonusGoal(){
                textGoal.text = "+3";
                anim.SetBool("isBonus", true);
                animShake.SetBool("isGoalAnim", true);
                StartCoroutine(AnimationCoroutine());
                isGoal = true;
                deleteZombies = FindObjectOfType<Achievement>().count;
                isBonusGoal = true;
                PlayerPrefs.SetInt("Money", MoneyManager.Money);
                
                
                counts += 3;
                texts.text = counts.ToString();
                Achievement.isBonus = false;
    }
}
