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
    
    
    private void Start()
    {   
        
        
    }

    
    private void Update()
    {
        StartCoroutine(HealthManage());
        Die();

    }

    void Die(){
        if(health <=0){
            
            Debug.Log("0 HP");
            
            Time.timeScale = 0;
            dieMenu.SetActive(true);
        }
    }

    public IEnumerator HealthManage(){
        
            for(int i = 0; i < arrHearts.Length; i++){
                if(i+1 < health){
                    
                    arrHearts[i].sprite = heart;
                }

                if(i+1 > health){
                    anim = arrHearts[i].GetComponent<Animator>();
                    
                    anim.SetBool("isDamage", true);
                    yield return new WaitForSeconds(0.44f);
                    arrHearts[i].sprite = noHeart;
                }
            }   
    }

    
    
}