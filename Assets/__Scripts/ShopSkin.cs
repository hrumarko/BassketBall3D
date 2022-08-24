using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShopSkin : MonoBehaviour
{    public int numOfSkin;
    public int price;

    public int isEquip;
    public int isOpen;
    public TextMeshProUGUI priceText;

    void Start(){        
        isEquip = PlayerPrefs.GetInt(numOfSkin +"isEquipq");              
        isOpen = PlayerPrefs.GetInt(numOfSkin +"isOpenq");
        priceText.text = price.ToString();   
    }

    public void FixedUpdate(){
        if(SkinManager.numberSkin != this.numOfSkin){
            this.isEquip =0;
            PlayerPrefs.SetInt(numOfSkin + "isEquipq", isEquip);
        }
    }
    public void Buy(){
        if(isOpen == 0){
            if(MoneyManager.Money >= price){
                MoneyManager.Money -= price;                
                isOpen =1;
                PlayerPrefs.SetInt(numOfSkin +"isOpenq", isOpen);
            }
        }
    }
    public void Select(){
        if(isOpen == 1){
            SkinManager.numberSkin = numOfSkin;
            PlayerPrefs.SetInt("numOfSkin", SkinManager.numberSkin);
            isEquip = 1;
            PlayerPrefs.SetInt(numOfSkin + "isEquipq", isEquip);
        }
    }

    

    
}
