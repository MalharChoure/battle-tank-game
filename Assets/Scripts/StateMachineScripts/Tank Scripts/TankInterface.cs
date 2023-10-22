using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankInterface 
{
    virtual public void Enter(TankMainController obj) { }
    virtual public void Exit(TankMainController obj) { }
    virtual public void Tick(TankMainController obj) { }
}
