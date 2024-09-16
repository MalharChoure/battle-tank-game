using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    public TankModel model;
    [SerializeField] Rigidbody _rb;
    public TankView(TankModel model)
    {
        this.model = model;
        _rb=gameObject.GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if(model!=null)
        {
            _rb.AddForce(transform.forward * 10 * model.Speed * Input.GetAxisRaw("VerticalUI"), ForceMode.Force);
        }
    }

    private void Update()
    {
        if (model != null)
        {
            transform.RotateAround(transform.position, Vector3.up, model.TurnSpeed * Input.GetAxis("HorizontalUI"));
            //Debug.Log(Input.GetAxis("HorizontalUI") + " " + Input.GetAxis("VerticalUI"));
        }
        
    }
}
