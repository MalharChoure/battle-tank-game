using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellService : MonoBehaviour
{
    [SerializeField] ShellView shellView;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            createShell();
        }
    }

    public ShellControler createShell()
    {
        Vector3 pos = transform.position + transform.forward * 1 + transform.up * 1.5f;
        ShellModel model = new ShellModel(10);
        ShellControler shell=new ShellControler(model,shellView,pos);
        return shell;
    }
}
