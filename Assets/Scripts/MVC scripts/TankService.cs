using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoBehaviour
{
    //[SerializeField] TankView[] models;
    [SerializeField] TankScriptableObjectsList list;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            createNewTank(1);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            createNewTank(0);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            createNewTank(2);
        }

    }

    private TankController createNewTank(int index)
    {
        TankModel model = new TankModel(list.list[index]);
        TankController tank = new TankController(model, list.list[index].tankview);
        return tank;
    }
}
