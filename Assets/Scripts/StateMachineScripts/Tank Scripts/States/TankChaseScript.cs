using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankChaseScript : TankInterface
{
    Transform player;
    public override void Enter(TankMainController obj)
    {
        player = DestroyerScript.player.TankV.transform;
    }

    public override void Exit(TankMainController obj) 
    {

    }

    public override void Tick(TankMainController obj)
    {
        if(player != null && Vector3.Magnitude(player.position - obj.transform.position)<13)
        {
            obj.statemachine.changeState(tankState.Attack);
        }
        else if(player != null && Vector3.Magnitude(player.position - obj.transform.position) >40)
        {
            obj.statemachine.changeState(tankState.Patrolling);
        }
        else
        {
            if (player != null)
            {
                obj.rb.AddForce(((player.position - obj.transform.position) / Vector3.Magnitude(player.position - obj.transform.position)) * 150);
                obj.transform.LookAt(player.position);
            }
            else
            {
                player = DestroyerScript.player.TankV.transform;
            }
        }
    }
}
