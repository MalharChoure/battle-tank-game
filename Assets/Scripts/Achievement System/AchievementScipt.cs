using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AchievementScipt : MonoSingletonGeneric<AchievementScipt>
{
    public static UnityEvent OnFire= new UnityEvent();
    
    private void Start()
    {
        OnFire.AddListener(BulletsFiredAchievement);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BulletsFiredAchievement()
    {
        Debug.Log("Check Fired");
        int bullets= PlayerPrefs.GetInt("Bullets", 0);
        bullets += 1;
        Debug.Log(bullets);
        PlayerPrefs.SetInt("Bullets",bullets);
        AchievementGameUI.OnFired.Invoke();
    }
}
