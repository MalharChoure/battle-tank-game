using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingletonGeneric<T> : MonoBehaviour where T : MonoSingletonGeneric<T>
{
    private static T instance;
    public static T Instance { get { return instance; } }
    protected virtual void Awake()
    {
        if(instance==null)
        {
            instance = (T)this;
        }
        else
        {
            Debug.LogError("A duplicate instance of the singleton object " + instance + " was being created");
            Destroy(this);
        }
    }
}
