using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoBehaviour
{
    //[SerializeField] TankView[] models;
    [SerializeField] TankScriptableObjectsList list;
    bool triggeronce = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (triggeronce)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                DestroyerScript.player = createNewTank(1);
                triggeronce = false;
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                DestroyerScript.player = createNewTank(0);
                triggeronce = false;
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                DestroyerScript.player = createNewTank(2);
                triggeronce = false;
            }
        }

    }

    private TankController createNewTank(int index)
    {
        TankModel model = new TankModel(list.list[index]);
        TankController tank = new TankController(model, list.list[index].tankview);
        return tank;
    }
}
