using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsOfLevel : MonoBehaviour
{
    public static int[] LevelStars = new int[100];

    void Awake(){
        for(int i = 1; i< 8; i++){
            LevelStars[i] = PlayerPrefs.GetInt(i + "stars");
            Debug.Log($"{i} + {LevelStars[i]}");
        }
    }
}
