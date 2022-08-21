using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public static int numberSkin = 0;


    private void Start()
    {
        numberSkin = PlayerPrefs.GetInt("numOfSkin");
        Debug.Log(numberSkin);
    }
    
    void FixedUpdate(){
        
    }
}
