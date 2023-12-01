using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGround : MonoBehaviour
{
    // Author: Madina Sarybay
    // Destroy Ground
    
    void Start()
    {
        StartCoroutine(DestroyGrounds());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DestroyGrounds()
    {
        yield return new WaitForSeconds(120);
        Destroy(gameObject);
    }
}
