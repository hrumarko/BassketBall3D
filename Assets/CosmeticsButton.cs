using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CosmeticsButton : MonoBehaviour
{
    public TextMeshProUGUI lockText;
    public GameObject spriteEquip;
    ShopSkin shop;

    void Start(){
        shop = GetComponent<ShopSkin>();
        
        
    }
    void FixedUpdate(){
        if(shop.isOpen == 1){
            lockText.text = "";
            
        }else if(shop.isOpen == 0){
            lockText.text = "LOCKED";
            
        }

        if(shop.isEquip == 1){
            spriteEquip.SetActive(true);
            
        }else if(shop.isEquip == 0){
            spriteEquip.SetActive(false);
            
        }

        
    }
}
