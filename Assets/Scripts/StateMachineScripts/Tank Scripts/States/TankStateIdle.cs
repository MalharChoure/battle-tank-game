using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankStateIdle : TankInterface
{
    public override void Enter(TankMainController obj)
    {
        
    }

    public override void Exit(TankMainController obj)
    {
        
    }

    public override void Tick(TankMainController obj)
    {
        obj.statemachine.changeState(tankState.Chase);
    }
}
