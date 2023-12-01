using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    // Author: Madina Sarybay
    // Generate Tile

    public GameObject[] section;
    public int zPos = 120;
    public bool creatingSection = false;
    public int secNum;
    void Start()
    {
        
    }

    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 2);
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 120;
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
}
