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
        if(shop.isLocked == false){
            lockText.text = "";
        }else if(shop.isLocked == true){
            lockText.text = "LOCKED";
        }

        if(shop.isEquipped == true){
            spriteEquip.SetActive(true);
        }else if(shop.isEquipped == false){
            spriteEquip.SetActive(false);
        }

        
    }
}
