using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public List<GameObject> zombies;
    public GameObject achievement;

    void Start(){
        FindObjectOfType<Achievement>().SetCount(2);
        Instantiate(achievement, new Vector3(-0.27f, 0, 8.20f), Quaternion.identity);
    }
}
