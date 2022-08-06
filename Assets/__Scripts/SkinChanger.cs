using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinChanger : MonoBehaviour
{
    public GameObject[] skins;
    // Start is called before the first frame update
    void Start()
    {
        SetSkin(SkinManager.numberSkin);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetSkin(int num){
        if(num < skins.Length){
            skins[num].SetActive(true);
        }
    }


}
