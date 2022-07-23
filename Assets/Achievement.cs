using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Achievement : MonoBehaviour
{
    public TextMeshPro achieveText;
    public int count;
    public int width;
    public int height;
    public static bool isBonus = false;
    

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    private void Update()
    {
        //Debug.Log(isBonus);
    }
    public void SetCount(int num){
        count = num;
        achieveText.text = $"- {num}";
    }

    public void SetScale(int width, int height){
        this.height = height;
        this.width = width;

        transform.localScale = new Vector3(width, 0.07f, height);

    }


    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player" && Player.isThrow ){
            isBonus = true;
            Debug.Log("AAAAAA");
        }
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if(other.gameObject.tag == "Player" ){
    //         isBonus = false;
    //         Player.isThrow = false;
    //     }
    // }
    
  
    
}
