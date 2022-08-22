using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelManager : MonoBehaviour
{
    public static int numberOfLevel;
    public static int curentScore ;
    public static int currentZombiecScore;
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
        currentZombiecScore =0;
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

                if(numberOfLevel == 8){
                    curentScore = 50;
                    if(StarsOfLevel.LevelStars[numberOfLevel]<3){
                    reward = 23;
                    }else{
                        reward = 0;
                    }
                    taskText.text = "score 50 points";
                }

                if(numberOfLevel == 9){
                    curentScore = 50;
                    currentZombiecScore = 4;                    
                    if(StarsOfLevel.LevelStars[numberOfLevel]<3){
                    reward = 25;
                    }else{
                        reward = 0;
                    }
                    taskText.text = "score 50 points.   killed 4 zombies";
                }
                if(numberOfLevel == 10){
                    curentScore = 50;
                    currentZombiecScore = 6;
                    if(StarsOfLevel.LevelStars[numberOfLevel]<3){
                    reward = 27;
                    }else{
                        reward = 0;
                    }
                    taskText.text = "score 50 points.   killed 6 zombies";
                }
                if(numberOfLevel == 11){
                    curentScore = 50;
                    currentZombiecScore = 9;
                    if(StarsOfLevel.LevelStars[numberOfLevel]<3){
                    reward = 29;
                    }else{
                        reward = 0;
                    }
                    taskText.text = "score 50 points. killed 9 zombies";
                }
                if(numberOfLevel == 12){
                    curentScore = 50;
                    currentZombiecScore = 13;
                    if(StarsOfLevel.LevelStars[numberOfLevel]<3){
                    reward = 31;
                    }else{
                        reward = 0;
                    }
                    taskText.text = "score 50 points.   killed 13 zombies";
                }
                if(numberOfLevel == 13){
                    curentScore = 50;
                    currentZombiecScore = 18;
                    if(StarsOfLevel.LevelStars[numberOfLevel]<3){
                    reward = 33;
                    }else{
                        reward = 0;
                    }
                    taskText.text = "score 50 points.   killed 18 zombies";
                }
                if(numberOfLevel == 14){
                    curentScore = 50;
                    currentZombiecScore = 24;
                    if(StarsOfLevel.LevelStars[numberOfLevel]<3){
                    reward = 35;
                    }else{
                        reward = 0;
                    }
                    taskText.text = "score 50 points.   killed 24 zombies";
                }
                if(numberOfLevel == 15){
                    curentScore = 50;
                    currentZombiecScore = 31;
                    if(StarsOfLevel.LevelStars[numberOfLevel]<3){
                    reward = 37;
                    }else{
                        reward = 0;
                    }
                    taskText.text = "score 50 points.   killed 31 zombies";
                }
                if(numberOfLevel == 16){
                    curentScore = 50;
                    currentZombiecScore = 39;
                    if(StarsOfLevel.LevelStars[numberOfLevel]<3){
                    reward = 39;
                    }else{
                        reward = 0;
                    }
                    taskText.text = "score 50 points.   killed 39 zombies";
                }
                if(numberOfLevel == 17){
                    curentScore = 50;
                    currentZombiecScore = 48;
                    if(StarsOfLevel.LevelStars[numberOfLevel]<3){
                    reward = 41;
                    }else{
                        reward = 0;
                    }
                    taskText.text = "score 50 points.   killed 48 zombies";
                }

                if(numberOfLevel == 18){
                    curentScore = 50;
                    currentZombiecScore = 50;
                    if(StarsOfLevel.LevelStars[numberOfLevel]<3){
                    reward = 43;
                    }else{
                        reward = 0;
                    }
                    taskText.text = "score 50 points.   killed 50 zombie";
                }

                if(numberOfLevel == 0){
                    taskText.text = "highscore is ";
                }

                

    }
    void Start()
    {
   
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Goal.counts >= curentScore && Game.money > currentZombiecScore && countCall == 0){
            countCall = 1;
            Winning();
            
        }
    }

    public void Winning(){
            gamePlay.GetComponent<Game>().DestroyAllZombies();
            PlayerPrefs.SetInt(numberOfLevel + "stars", HealthManager.health);
            Debug.Log("OP");
            zombie.SetActive(false);
            player.enabled = false;
            gamePlay.SetActive(false);
            
            
            gameOverCanvas.SetActive(true);
            gameOverAnim.SetBool("isWin", true);
            collectedCoins.text = "zombie-coin collected - " + HealthManager.health*reward;
            MoneyManager.Money += HealthManager.health*reward;
            PlayerPrefs.SetInt("Money", MoneyManager.Money);
            gameOverAnim.SetInteger("stars", HealthManager.health);
            
    }
}
