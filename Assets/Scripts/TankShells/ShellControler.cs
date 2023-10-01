using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellControler
{
    public ShellControler(ShellModel model, ShellView view,Vector3 pos) 
    {
        Model= model;
        View = GameObject.Instantiate<ShellView>(view,pos,Quaternion.identity);
    }

    public ShellModel Model { get; }

    public ShellView View { get; }
}
