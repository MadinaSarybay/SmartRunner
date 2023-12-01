using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelStarter : MonoBehaviour
{
    // Author: Madina Sarybay
    // Start Counter

    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGo;
    public GameObject fadeIn;
    public AudioSource goFX;
    public AudioSource readyFX;

    void Start()
    {
        StartCoroutine(CountSequnce());
    }

    void Update()
    {
        
    }

    IEnumerator CountSequnce()
    {
        yield return new WaitForSeconds(1.5f);
        countDown3.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1f);
        countDown2.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1f);
        countDown1.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1f);
        countDownGo.SetActive(true);
        goFX.Play();
        PlayerMovement.canMove = true;
    }
}
