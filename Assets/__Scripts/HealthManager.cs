using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public static int health = 3;
    public Sprite heart;
    public Sprite noHeart;
    public Image[] arrHearts;
    Animator anim;
    public GameObject dieMenu;
    
    
    public void Recovery()
    {   
        for(int i = 0; i < arrHearts.Length; i++){                    
            anim = arrHearts[i].GetComponent<Animator>();
                    
            anim.SetBool("isDamage", false);
            
        }
        
        
    }

    
    private void Update()
    {
        // StartCoroutine(HealthManage());
        Health();
        Die();

    }

    void Die(){
        if(health <=0){
            
            Debug.Log("0 HP");
            //health = 3;
            //Time.timeScale = 0;
            //dieMenu.SetActive(true);
        }
    }

    public void Health(){
        if(health == 3){
            for(int i = 0; i < arrHearts.Length; i++){                    
                arrHearts[i].sprite = heart;  
            
            }
        }

        if(health == 2){
            for(int i = 0; i < arrHearts.Length-1; i++){                    
                arrHearts[i].sprite = heart;  
            
            }
            anim = arrHearts[2].GetComponent<Animator>();
                    
            anim.SetBool("isDamage", true);
            arrHearts[2].sprite = noHeart; 
        }

        if(health == 1){
            for(int i = 0; i < arrHearts.Length-2; i++){                    
                arrHearts[i].sprite = heart;  
            
            }
            
            arrHearts[1].sprite = noHeart;

            anim = arrHearts[1].GetComponent<Animator>();
                    
            anim.SetBool("isDamage", true);
        }
    }
    public IEnumerator HealthManage(){
        
            for(int i = 0; i < arrHearts.Length; i++){
                if(i+1 < health){
                    
                    arrHearts[i].sprite = heart;
                }

                if(i+1> health){

                    yield return new WaitForSeconds(0.44f);
                    arrHearts[i].sprite = noHeart;
                }
            }   
    }

    
    
}