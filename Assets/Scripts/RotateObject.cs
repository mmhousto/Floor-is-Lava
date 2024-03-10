using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float spinSpeed;
    public Vector3 axis;

    private void Update()
    {
        transform.Rotate(axis * spinSpeed * Time.deltaTime);
    }
}
