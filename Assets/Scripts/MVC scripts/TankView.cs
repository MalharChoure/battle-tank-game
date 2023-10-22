using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    public TankModel model;
    public TankController controller;
    [SerializeField] Rigidbody _rb;
    
    public TankView(TankModel model,TankController controller)
    {
        this.model = model;
        this.controller = controller;
        _rb=gameObject.GetComponent<Rigidbody>();
    }

    public void Start()
    {
        Debug.Log("Created");
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

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        model.dead = true;
    }
}
