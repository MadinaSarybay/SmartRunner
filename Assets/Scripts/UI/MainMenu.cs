using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /// Author: Madina Sarybay
    // Main menu script
    private bool creditsGame;
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Credits()
    {
        
    }

    public void Quit()
    {
        Application.Quit();
    }

}
