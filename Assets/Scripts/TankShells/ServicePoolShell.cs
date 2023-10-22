using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServicePoolShell : ServicePool<ShellControler>
{
    private ShellView shellPref;
    private ShellModel shellModel;
    private Vector3 pos;
    private Vector3 dir;

    public ShellControler getShell(ShellModel shell,ShellView view,Vector3 pos,Vector3 dir)
    {
        shellPref = view;
        shellModel = shell;
        this.pos = pos;
        this.dir = dir; 
        return CreateItem();
    }

    protected override ShellControler CreateItem() 
    {
        ShellControler controller = new ShellControler(shellModel, shellPref,pos,dir);
        return controller;
    }
}
