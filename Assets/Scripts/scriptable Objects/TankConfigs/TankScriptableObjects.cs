using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="TankScriptableObject", menuName ="Scriptable Object/TankScriptableObject")]
public class TankScriptableObjects : ScriptableObject
{
    public int health;
    public int speed;
    public tankType type;
    public TankView tankview;
    public int turnSpeed;
}




public enum tankType
{
    Brown,
    Green,
    Blue
}