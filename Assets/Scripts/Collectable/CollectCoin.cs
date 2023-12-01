using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    // Author: Madina Sarybay
    // Collect Coin

    public AudioSource coinFX;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        CollectControl.coinCount += 1;
        this.gameObject.SetActive(false);
    }
}
