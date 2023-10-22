using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TankScriptableObjectList", menuName = "Scriptable Object/TankScriptableObjectList")]
public class TankScriptableObjectsList : ScriptableObject
{
    public TankScriptableObjects[] list;
}
