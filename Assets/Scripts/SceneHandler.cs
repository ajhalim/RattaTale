//reference https://www.youtube.com/watch?v=pcyiub1hz20

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneHandler : MonoBehaviour
{
    //Start Play and go to interval
    public void Play()
    {
        //Assume game scene is 1
        SceneManager.LoadScene(1);
    }

    //Quit the game
    public void QuitGame()
    {
        Debug.Log("Player Exit Game");
        Application.Quit();
    }

    public void GameOver()
    {
        //Assume end screen is 2
        SceneManager.LoadScene(2);
    }

    public void StartMenu()
    {
        //Assume start scene is 0
        SceneManager.LoadScene(0);
    }

}
