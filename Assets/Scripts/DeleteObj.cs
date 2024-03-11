using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObj : MonoBehaviour
{
    public GameObject lid;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Spring"))
        {
            Destroy(lid, 0.5f);
            Destroy(gameObject, 0.5f);
            
        }
        
    }
}
