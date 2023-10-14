using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMainController : MonoBehaviour
{
    public Transform StartPos;
    public Transform EndPos;
    public TankStateMachine statemachine;
    public Rigidbody rb;

    public void Start()
    {
        statemachine = new TankStateMachine(this);
        TankInterface tankIdle = new TankStateIdle();
        TankInterface tankPatrol = new TankPatrollingState();
        TankInterface tankChase = new TankChaseScript();
        TankInterface tankFire = new TankFireState();
        statemachine.addState(tankState.Idle,tankIdle);
        statemachine.addState(tankState.Patrolling, tankPatrol);
        statemachine.addState(tankState.Chase, tankChase);
        statemachine.addState(tankState.Attack, tankFire);
    }

    public void Update()
    {
        statemachine.tick();
    }

}
