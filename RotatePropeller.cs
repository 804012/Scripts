using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    private float rotationspeed = 1500.0f;

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationspeed);
    }
}