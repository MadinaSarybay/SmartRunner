using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Author: madna Sarybay
    // Rotate Coin

    public int rotateSpeed = 1;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}
