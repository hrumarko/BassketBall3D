using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class RewardedAdsCoins : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener 
{
    [SerializeField] private Button buttonShowAd;
    [SerializeField] private string androidAdID = "Rewarded_Android";
    [SerializeField] private string iOSAdID = "Rewarded_iOS";


    private string adID;

    void Awake(){
        adID = (Application.platform == RuntimePlatform.IPhonePlayer)
            ? iOSAdID
            : androidAdID;
        buttonShowAd.interactable = false;
    }

    private void Start(){
        LoadAd();
    }

    public void LoadAd(){
        Advertisement.Load(adID, this);
    }

    public void ShowAd(){
        Advertisement.Show(adID, this);
    }

    public void OnUnityAdsAdLoaded(string adUnitId){
        if(adUnitId.Equals(adID)){
            buttonShowAd.onClick.AddListener(ShowAd);
            buttonShowAd.interactable = true;
        }
    }
    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message){

    }

    public void OnUnityAdsShowClick(string placementId){

    }
    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState){
       
        MoneyManager.Money =MoneyManager.Money +  100;
        PlayerPrefs.SetInt("Money", MoneyManager.Money);
            

    }
    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message){

    }
    public void OnUnityAdsShowStart(string placementId){

    }
}
