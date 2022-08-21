using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelManager : MonoBehaviour
{
    public static int numberOfLevel;
    public static int curentScore ;
    public GameObject gameOverCanvas;
    public TextMeshProUGUI taskText;
    public TextMeshProUGUI collectedCoins;
    public Animator gameOverAnim;
    int reward;

    [SerializeField] GameObject zombie;
    [SerializeField] Player player;
    [SerializeField] GameObject gamePlay;

    public static int countCall = 0;
    void Awake(){
        zombie.SetActive(true);
        player.enabled = true;
        gamePlay.SetActive(true);
        numberOfLevel = PlayerPrefs.GetInt("numberOfLevel");
                if(numberOfLevel == 1){
                    curentScore = 9;
                    if(StarsOfLevel.LevelStars[numberOfLevel]<3){
                        reward = 5;
                    }else{
                        reward = 0;
                    }
                    taskText.text = "score 9 points";
                }

                if(numberOfLevel == 2){
                    curentScore = 12;
                    if(StarsOfLevel.LevelStars[numberOfLevel]<3){
                    reward = 6;
                    }else{
                        reward = 0;
                    }
                    taskText.text = "score 12 points";
                }

                if(numberOfLevel == 3){
                    curentScore = 16;
                    if(StarsOfLevel.LevelStars[numberOfLevel]<3){
                    reward = 8;
                    }else{
                        reward = 0;
                    }
                    taskText.text = "score 16 points";
                }

                if(numberOfLevel == 4){
                    curentScore = 21;
                    if(StarsOfLevel.LevelStars[numberOfLevel]<3){
                    reward = 10;
                    }else{
                        reward = 0;
                    }
                    taskText.text = "score 21 points";
                }

                if(numberOfLevel == 5){
                    curentScore = 27;
                    if(StarsOfLevel.LevelStars[numberOfLevel]<3){
                    reward = 12;
                    }else{
                        reward = 0;
                    }
                    taskText.text = "score 27 points";
                }

                if(numberOfLevel == 6){
                    curentScore = 34;
                    if(StarsOfLevel.LevelStars[numberOfLevel]<3){
                    reward = 17;
                    }else{
                        reward = 0;
                    }
                    taskText.text = "score 34 points";
                }

                if(numberOfLevel == 7){
                    curentScore = 42;
                    if(StarsOfLevel.LevelStars[numberOfLevel]<3){
                    reward = 21;
                    }else{
                        reward = 0;
                    }
                    taskText.text = "score 42 points";
                }

                

    }
    void Start()
    {
   
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Goal.counts >= curentScore && countCall == 0){
            countCall = 1;
            Winning();
            
        }
    }

    public void Winning(){
            PlayerPrefs.SetInt(numberOfLevel + "stars", HealthManager.health);
            zombie.SetActive(false);
            player.enabled = false;
            gamePlay.SetActive(false);
            gamePlay.GetComponent<Game>().DestroyAllZombies();
            
            gameOverCanvas.SetActive(true);
            gameOverAnim.SetBool("isWin", true);
            collectedCoins.text = "zombie-coin collected - " + HealthManager.health*reward;
            MoneyManager.Money += HealthManager.health*reward;
            PlayerPrefs.SetInt("Money", MoneyManager.Money);
            gameOverAnim.SetInteger("stars", HealthManager.health);
            
    }
}
