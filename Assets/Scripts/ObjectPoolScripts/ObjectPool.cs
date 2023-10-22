using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObjectPool : MonoSingletonGeneric<ObjectPool>
{
    public Queue<GameObject> pool;
    public int size=100;
    public GameObject shell;

    private void Start()
    {
        pool= new Queue<GameObject>();
        for (int i = 0; i < size; i++)
        {
            GameObject temp = Instantiate(shell,gameObject.transform);
            
            temp.SetActive(false);
            pool.Enqueue(Instantiate(shell,new Vector3(0,1000,0),Quaternion.identity));

        }
    }

    public GameObject Create(Vector3 position,Quaternion rotation)
    {
        GameObject temp = pool.Dequeue();
        temp.SetActive(true); 
        temp.transform.position = position; 
        temp.transform.rotation = rotation;
        return temp;
    }

    public void PushBack(GameObject poolobj)
    {
        poolobj.SetActive(false);
        pool.Enqueue(poolobj);
    }
    
}
