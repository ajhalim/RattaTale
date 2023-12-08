using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playScript : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        PlayerPrefs.SetFloat("playTime", 0);
        PlayerPrefs.SetFloat("lastRun", 90);
        PlayerPrefs.SetInt("numRuns", 0);
        SceneManager.LoadScene(sceneName);
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
