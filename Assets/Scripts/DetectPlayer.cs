using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    public RotateObject rotateObject;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rotateObject.spinSpeed = 180;
            Invoke(nameof(StopSpinning), 4.5f);
        }
    }

    private void StopSpinning()
    {
        rotateObject.spinSpeed = 0;
    }

}
