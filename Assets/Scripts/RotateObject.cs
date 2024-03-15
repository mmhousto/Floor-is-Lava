using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float spinSpeed;
    public Vector3 axis;
    public bool physically;
    private Rigidbody rb;

    private void Start()
    {
        if (physically == true) rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (physically == false)
        { 
            transform.Rotate(axis * spinSpeed * Time.deltaTime);
        }
        
    }

    private void FixedUpdate()
    {
        if (physically == true)
        {
            rb.AddTorque(axis * spinSpeed, ForceMode.Impulse);
        }
    }
}
