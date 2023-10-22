using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankStateMachine 
{
    public tankState currentState = tankState.Idle;
    public TankMainController controller;

    public TankStateMachine(TankMainController main)
    {
        controller = main;
    }

    public TankInterface[] states=new TankInterface[10];
    public void tick() 
    {
        states[(int)currentState].Tick(controller);
    }
    public void addState(tankState stateTpye,TankInterface state) 
    {
        states[(int)stateTpye] = state;
    }

    public void changeState(tankState state)
    {
        states[(int)currentState].Exit(controller);
        currentState = state;
        states[(int)currentState].Enter(controller);
    }
}

public enum tankState 
{
    Idle,
    Patrolling,
    Attack,
    Chase
}
