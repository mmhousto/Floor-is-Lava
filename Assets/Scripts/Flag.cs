using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    public GameObject flag;
    private float yDelta;
    private float lastY;
    // Start is called before the first frame update
    void Start()
    {
        lastY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y != lastY && transform.position.y < lastY)
        {
            yDelta = lastY - transform.position.y;
            lastY = transform.position.y;
            flag.transform.Translate(new Vector3 (0, yDelta, 0));
        }
    }
}
