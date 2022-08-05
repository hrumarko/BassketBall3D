using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Game : MonoBehaviour
{
    public List<GameObject> zombies;
    public GameObject achievement;
    public GameObject zombie;
    public TextMeshProUGUI zombieCoinText;
    int money;
    public GameObject particle;
   
    GameObject achieve;
    

    void Start(){
        
        StartCoroutine(FixedSpawnZombies());
        achieve = Instantiate(achievement, new Vector3(-0.27f, 0, 8.20f), Quaternion.identity);
        FindObjectOfType<Achievement>().SetCount(Random.Range(1, zombies.Count));
        FindObjectOfType<Achievement>().SetScale(Random.Range(4, 7), Random.Range(4, 7));
    }
   
    private void Update()
    {

        if(Goal.isBonusGoal){
            if(achieve != null)
            {
                Destroy(achieve);
                Achievement.isBonus = false;
            }
            
            DestroyZombies(Goal.deleteZombies);
            MoneyManager.Money += Goal.deleteZombies;
            PlayerPrefs.SetInt("Money", MoneyManager.Money);
            money += Goal.deleteZombies;
            zombieCoinText.text = money.ToString();
            achieve = Instantiate(achievement, new Vector3(Random.Range(-6,9), 0, Random.Range(0,12)), Quaternion.identity);
            CountAchieve();
            FindObjectOfType<Achievement>().SetScale(Random.Range(4, 7), Random.Range(4, 7));
            Goal.isBonusGoal = false;
        }
        
        
        
    }

    void SpawnZombies(){
        float x = Random.Range(-12f, 12f);
        float z = Random.Range(-13f, 10f);
        Vector3 randPos = new Vector3(x, 0.71f, z);
        GameObject zmbie = Instantiate<GameObject>(zombie, randPos, Quaternion.identity);
        zombies.Add(zmbie);
    }

    public IEnumerator FixedSpawnZombies(){
        while(true){
            SpawnZombies();
            yield return new WaitForSeconds(6f);
        }
    }

    public void DestroyZombies(int num){
        {
            if(num < zombies.Count){
                for(int i = 0; i <num; i++){
                    if(zombies[i] != null){
                        
                        Destroy(zombies[i]);
                        GameObject go = Instantiate(particle, zombies[i].transform.position, Quaternion.identity);
                        Destroy(go, 1);
                        zombies.Remove(zombies[i]);
                    }
                    
                }
            }else{
                for(int i = 0; i <zombies.Count; i++){
                    Destroy(zombies[i]);
                    GameObject go = Instantiate(particle, zombies[i].transform.position, Quaternion.identity);
                    Destroy(go, 1);
                    zombies.Remove(zombies[i]);
                }
            }
        }
        
    }

    void CountAchieve(){
        if(zombies.Count< 4){
                FindObjectOfType<Achievement>().SetCount(Random.Range(0, 3));
            }else if(zombies.Count >3){
                FindObjectOfType<Achievement>().SetCount(Random.Range(3, zombies.Count));
            }
    }


    
}
