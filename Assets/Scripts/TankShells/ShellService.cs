using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellService : MonoBehaviour
{
    [SerializeField] ShellView shellView;
    private ServicePoolShell shellpool;
    // Start is called before the first frame update
    void Start()
    {
        shellpool=GetComponent<ServicePoolShell>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            createShell();
            AchievementScipt.OnFire.Invoke();
        }
    }

    public ShellControler createShell()
    {
        Vector3 pos = transform.position + transform.forward * 1 + transform.up * 1.5f;
        ShellModel model = new ShellModel(10);
        // GameObject temp = ObjectPool.Instance.Create(pos,shellView.transform.rotation);
        //temp.SetActive(true);
        //ShellView view = temp.GetComponent<ShellView>();
        //Debug.Log(pos - transform.position);
        ShellControler shell = shellpool.getShell(model, shellView, pos, pos - transform.position);//new ShellControler(model,shellView,pos,pos-transform.position);
        return shell;
    }
}
