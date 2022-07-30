using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MoneyManager : MonoBehaviour
{
    public static int Money = 0;

    public TextMeshProUGUI moneyText;

    
    private void FixedUpdate()
    {
        moneyText.text = Money.ToString();
        PlayerPrefs.SetInt("Money", Money);
        Money = PlayerPrefs.GetInt("Money", Money);
    }
}
