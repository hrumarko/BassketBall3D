using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSkin : MonoBehaviour
{
    public int numOfSkins;
    public bool isEquipped;
    public bool isLocked;
    public int price;
    [Header("Bollean Numbers")]
    public int isEquipNum;
    public int isLockedNum;             //1 -true // 0 - false

    void Start(){
        PlayerPrefs.DeleteAll();
        isLockedNum = PlayerPrefs.GetInt("isLockedNum", isLockedNum);

        isEquipNum = PlayerPrefs.GetInt("isEquipNum", isEquipNum);
    }
    
    

   private void FixedUpdate()
   {    
        BoolChek();
        SetSkins();
   }
    public void Select(){
        if(!isLocked){
            SkinManager.numberSkin = numOfSkins;
        }
    }

    public void Buy(){
        if(isLocked){
            if(MoneyManager.Money >= price){
                MoneyManager.Money -= price;
                
                isLockedNum = 0;
                //PlayerPrefs.SetInt("isLockedNum", isLockedNum);
            }
            else{
                Debug.Log("A nety deneg to!!!xD");
            }
        }
    }

    public void BoolChek(){
        if(isEquipNum == 1){
            isEquipped = true;
        } else if(isEquipNum == 0){
            isEquipped = false;
        }

        if(isLockedNum == 1){
            isLocked = true;
            PlayerPrefs.SetInt("isLockedNum", isLockedNum);
        } else{
            isLocked = false;
            PlayerPrefs.SetInt("isLockedNum", isLockedNum);
        }
        // if(isLocked){
        //     isLockedNum = 1;
        //     //PlayerPrefs.SetInt("isLockedNum", isLockedNum);
        // }
        
    }

    public void SetSkins(){
        if(numOfSkins==SkinManager.numberSkin){
        //isEquipped = true;
        isEquipNum = 1;
        PlayerPrefs.SetInt("isEquipNum", isEquipNum);
    }else{
        //isEquipped = false;
        isEquipNum = 0;
        PlayerPrefs.SetInt("isEquipNum", isEquipNum);
    }

    
    }

    

    
}
