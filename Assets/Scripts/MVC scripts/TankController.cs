using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TankController 
{
    
    public TankController(TankModel tankModel,TankView tankPrefab)
    {
        TankModel = tankModel;
        TankV = GameObject.Instantiate<TankView>(tankPrefab);
        TankV.controller = this;
        TankV.model = tankModel;
    }

    public TankModel TankModel { get; }
    public TankView TankV { get;}

    public void test()
    {
        Debug.Log("Here");
    }

}
