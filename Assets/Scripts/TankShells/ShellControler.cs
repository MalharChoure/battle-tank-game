using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellControler
{
    public ShellControler(ShellModel model, ShellView view,Vector3 pos, Vector3 dir) 
    {
        Model= model;


        GameObject.Instantiate<ShellView>(view,pos,Quaternion.identity);
        front = dir;
        view.dir = dir;
    }

    public ShellModel Model { get; }

    public ShellView View { get; }

    public Vector3 front { get; }
}
