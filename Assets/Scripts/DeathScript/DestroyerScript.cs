using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyerScript : MonoSingletonGeneric<DestroyerScript>
{
    public List<GameObject> obj;
    public static TankController player;
    public bool destroyall = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player != null && !destroyall)
        {
            Debug.Log(player.TankModel.dead);
            if (player.TankModel.dead)
            {
                destroyAll();
                destroyall = true;
            }
        }
    }

    public void destroyAll()
    {
        StartCoroutine(destruct());
    }

    public IEnumerator destruct()
    {
        yield return new WaitForSeconds(2f);
        if(obj.Count>0)
        {
            GameObject temp = obj[0];
            obj.Remove(temp);
            StartCoroutine(destruct());
            Destroy(temp);
        }
        else
        {
            Destroy(player.TankV.gameObject);
        }
        
    }
}
