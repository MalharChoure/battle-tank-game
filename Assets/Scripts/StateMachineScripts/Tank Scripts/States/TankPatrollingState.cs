using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPatrollingState : TankInterface
{
    private float step = 0;
    private float time=3;
    public override void Enter(TankMainController obj)
    {

    }

    public override void Exit(TankMainController obj)
    {
        step = 0;
    }

    public override void Tick(TankMainController obj)
    {
        step += Time.deltaTime / time;
        if (step <= 1)
        {
            obj.transform.LookAt(obj.EndPos);
            obj.transform.position = Vector3.Lerp(obj.StartPos.position, obj.EndPos.position, step);
        }
        else
        {
            Transform t = obj.StartPos;
            obj.StartPos = obj.EndPos;
            obj.EndPos = t;
            step = 0f;
        }

        if(DestroyerScript.player.TankV!=null && Vector3.Magnitude(DestroyerScript.player.TankV.transform.position-obj.transform.position)<40)
        {
            obj.statemachine.changeState(tankState.Chase);
        }
    }
}
