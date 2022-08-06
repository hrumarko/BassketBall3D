using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSkin : MonoBehaviour
{
    public int numOfSkins;
    public bool isEquipped;
    public bool isLocked;
    public int price;


    
    

   private void FixedUpdate()
   {
    if(numOfSkins==SkinManager.numberSkin){
        isEquipped = true;
    }else{
        isEquipped = false;
    }
   }
    public void Select(){
        if(!isLocked){
            Debug.Log(numOfSkins);
            
            SkinManager.numberSkin = numOfSkins;
            PlayerPrefs.SetInt("SkinManager.numberSkin", SkinManager.numberSkin);
        }
    }

    public void Buy(){
        if(isLocked){
            if(MoneyManager.Money >= price){
                MoneyManager.Money -= price;
                isLocked = false;
                Debug.Log("KYPIL");
                
            }
            else{
                Debug.Log("A nety deneg to!!!xD");
            }
        }
    }

    

    
}
