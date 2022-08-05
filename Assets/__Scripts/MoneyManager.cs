using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MoneyManager : MonoBehaviour
{
    public static int Money;

    public TextMeshProUGUI moneyText;

    void Start(){
        Money = PlayerPrefs.GetInt("Money", Money);
        moneyText.text = Money.ToString();
    }
    private void FixedUpdate()
    {
        moneyText.text = Money.ToString();
        
        
        
    }
}
