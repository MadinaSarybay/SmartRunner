using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    // Author: Madina Sarybay

    public static float leftSide = -3.5f;
    public static float rightSide = 3.5f;
    public float internalLeft;
    public float internalRight;


    void Start()
    {
        
    }

    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
