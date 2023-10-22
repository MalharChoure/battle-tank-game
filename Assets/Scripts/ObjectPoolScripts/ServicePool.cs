using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class ServicePool<T> : MonoSingletonGeneric<ServicePool<T>> where T : class
{

    private List<PooledItem<T>> poolItems= new List<PooledItem<T>>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public virtual T GetItem()
    {
        if(poolItems.Count>0)
        {
            PooledItem<T> item = poolItems.Find(i => i.isUsed == false);
            if(item!=null)
            {
                return item.item;
            }
            return createNewItems();
        }
        return createNewItems();
    }

    private T createNewItems()
    {
        PooledItem<T> temp = new PooledItem<T>();
        temp.item = CreateItem();
        temp.isUsed = true;
        poolItems.Add(temp);
        return temp.item;
    }

    public virtual void ReturnItem(T item)
    {
        PooledItem<T> pool = poolItems.Find(i => i.item.Equals(item));
        pool.isUsed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected virtual T CreateItem()
    {
        return (T) null;
    }

}

[Serializable]
public class PooledItem<T>
{
    public T item;
    public bool isUsed;
}
