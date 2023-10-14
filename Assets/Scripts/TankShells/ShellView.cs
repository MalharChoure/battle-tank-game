using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class ShellView : MonoBehaviour
{
    public Vector3 dir;
    [SerializeField] Rigidbody _rb;
    public ShellView(Vector3 dir)
    {
        this.dir = dir;
    }

    // Start is called before the first frame update

    void Start()
    {
        if (dir != null)
        {
            Debug.Log(dir);
            _rb.AddForce((dir  + new Vector3(0,-1,0))*10, ForceMode.Impulse);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
