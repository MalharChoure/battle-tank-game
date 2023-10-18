using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class TankFireState: TankInterface
{
    public override void Enter(TankMainController obj)
    {
        ShellService TankFService = obj.gameObject.GetComponent<ShellService>();
        TankFService.createShell();
        firedTimer(obj);
    }

    public override void Exit(TankMainController obj)
    {

    }

    public override void Tick(TankMainController obj)
    {

    }

    async void firedTimer(TankMainController obj)
    {
        await Task.Delay(2000);
        obj.statemachine.changeState(tankState.Chase);
    }
}
