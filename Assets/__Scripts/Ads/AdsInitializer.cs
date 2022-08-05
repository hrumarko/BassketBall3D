using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsInitializer : MonoBehaviour, IUnityAdsInitializationListener
{
    [SerializeField] string androidGameId = "4873691";
    [SerializeField] string iOSGameId = "4873690";
    [SerializeField] bool testMode = true;
    private string gameID;

    void Awake(){
        InitializeAds();
    }

    public void InitializeAds(){
        gameID = (Application.platform == RuntimePlatform.IPhonePlayer) ? iOSGameId : androidGameId;
        Advertisement.Initialize(gameID, testMode, this);
    }

    public void OnInitializationComplete(){

    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message){

    }

}
