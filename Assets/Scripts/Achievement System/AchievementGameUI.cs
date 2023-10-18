using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class AchievementGameUI : MonoSingletonGeneric<AchievementGameUI>
{
    public TMP_Text achievementText;
    public static UnityEvent OnFired= new UnityEvent();
    private string[] achievements = { "None","Shooter", "Master Hunstman", "AimBot" };
    private int currentAchievement = 0;
    private void Start()
    {
        achievementText.text = "";
        OnFired.AddListener(checkFired);
    }

    private void checkFired()
    {
        Debug.Log(PlayerPrefs.GetInt("Bullets"));
        if(PlayerPrefs.GetInt("Bullets")>=25 && PlayerPrefs.GetInt("Achievement", 0)<=3)
        {
            Debug.Log("Triggered");
            currentAchievement=PlayerPrefs.GetInt("Achievement", 0);
            currentAchievement=currentAchievement<3?currentAchievement+1:3;

            PlayerPrefs.SetInt("Achievement", currentAchievement);
            PlayerPrefs.SetInt("Bullets", 0);
            displayAchievment();
        }
    }

    private async void displayAchievment()
    {
        achievementText.text = achievements[PlayerPrefs.GetInt("Achievement", 0)];
        await Task.Delay(5000);
        achievementText.text = "";
    }

}
