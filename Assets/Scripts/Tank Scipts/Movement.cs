using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody _rb;
    [SerializeField] float _speed;
    [SerializeField] float _forwardforce;
    [SerializeField] float _turnSpeed;

    private void FixedUpdate()
    {
        _rb.AddForce(transform.forward* 10* Input.GetAxisRaw("VerticalUI"), ForceMode.Force);
    }

    private void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, _turnSpeed*Input.GetAxis("HorizontalUI"));
        Debug.Log(Input.GetAxis("HorizontalUI")+ " "+ Input.GetAxis("VerticalUI"));
    }

}
