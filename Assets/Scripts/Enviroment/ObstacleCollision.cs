using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    // Author: Madina Sarybay
    // Obstacle Script

    public GameObject player;
    public GameObject charModel;
    public GameObject levelControl;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble1");
        levelControl.GetComponent<EndGameScript>().enabled = true;
    }
}
