using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playScript : MonoBehaviour
{
    public int adasfdas;
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void ReleadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
