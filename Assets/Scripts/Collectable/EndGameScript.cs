using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameScript : MonoBehaviour
{
    // Author: Madina Sarybay
    // Ens Screen

    public GameObject resultCoin;
    public GameObject endScreen;
    public GameObject fadeOut;
    void Start()
    {
        StartCoroutine(EndScreen());
    }

    void Update()
    {
        
    }
    IEnumerator EndScreen()
    {
        yield return new WaitForSeconds(3);
        resultCoin.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(5);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}
