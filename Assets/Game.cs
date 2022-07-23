using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Game : MonoBehaviour
{
    public List<GameObject> zombies;
    public GameObject achievement;
    public GameObject zombie;
    bool isStart = false;
   
    GameObject achieve;
    

    void Start(){
        isStart = true;
        achieve = Instantiate(achievement, new Vector3(-0.27f, 0, 8.20f), Quaternion.identity);
            FindObjectOfType<Achievement>().SetCount(Random.Range(1, zombies.Count));
                    
            FindObjectOfType<Achievement>().SetScale(Random.Range(4, 7), Random.Range(4, 7));
        
    }
   
    private void Update()
    {

        if(Goal.isBonusGoal){
            Debug.Log(FindObjectOfType<Achievement>().count);
            DestroyZombies(FindObjectOfType<Achievement>().count);
            if(achieve != null) Destroy(achieve);
            
            achieve = Instantiate(achievement, new Vector3(-0.27f, 0, 8.20f), Quaternion.identity);
            float b = Mathf.Round(zombies.Count/2);
            if(zombies.Count>2){
                FindObjectOfType<Achievement>().SetCount(Random.Range((int)b, zombies.Count));
            }else{
                FindObjectOfType<Achievement>().SetCount(Random.Range(0, 2));
            }        
            FindObjectOfType<Achievement>().SetScale(Random.Range(4, 7), Random.Range(4, 7));
            Goal.isBonusGoal = false;
        }
        
        if(isStart){
            StartCoroutine(FixedSpawnZombies());
            isStart = false;
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
            yield return new WaitForSeconds(4f);
        }
    }

    public void DestroyZombies(int count){
        {
            for(int i = 0; i <count; i++){
                
                Destroy(zombies[i]);
                zombies.Remove(zombies[i]);
            }
               
        }
        
    }


    
}
