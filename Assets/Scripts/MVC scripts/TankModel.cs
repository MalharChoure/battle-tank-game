using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TankModel 
{
    public TankModel(TankScriptableObjects tank)
    {
        Type = tank.type;
        Health = tank.health;
        TurnSpeed = tank.turnSpeed;
        Speed = tank.speed;
    }
    public TankModel(int speed,int health,int turnSpeed,tankType type) 
    {
        Speed = speed;
        Health = health;
        TurnSpeed = turnSpeed;
        Type = type;
    }
    public int Speed { get; }
    public int Health { get; }
    public int TurnSpeed { get; }
    public tankType Type { get; }
}
