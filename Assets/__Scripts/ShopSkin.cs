using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSkin : MonoBehaviour
{    public int numOfSkin;
    public int price;

    public int isEquip;
    public int isOpen;

    void Start(){        
        isEquip = PlayerPrefs.GetInt(numOfSkin +"isEquipq");              
        isOpen = PlayerPrefs.GetInt(numOfSkin +"isOpenq");    
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
