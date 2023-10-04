using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    [SerializeField] Transform StartPos;
    [SerializeField] Transform EndPos;
    float step = 0f;
    [SerializeField] float time = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        step += Time.deltaTime/time;
        if(step<=1)
        {
            transform.LookAt(EndPos);
            transform.position = Vector3.Lerp(StartPos.position, EndPos.position, step);
        }
        else
        {
            Transform t = StartPos;
            StartPos = EndPos;
            EndPos = t;
            step = 0f;
        }
    }
}
