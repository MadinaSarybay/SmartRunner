using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectControl : MonoBehaviour
{
    // Author: Madina Sarybay
    // Collect Coin Control

    public static int coinCount;
    public GameObject coinCountDisplay;
    public GameObject coinEndDisplay;

    void Start()
    {
        
    }

    void Update()
    {
        
        coinCountDisplay.GetComponent<Text>().text = "" + coinCount; 
        coinEndDisplay.GetComponent<Text>().text = "" + coinCount;

    }
}
