using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Achievement : MonoBehaviour
{
    public TextMeshPro achieveText;
    int count;

    
    public void SetCount(int num){
        count = num;
        achieveText.text = $"- {num}";
    }
  
    private void Start()
    {
        SetCount(22);
    }
}
