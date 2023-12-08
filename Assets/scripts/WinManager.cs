using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinManager : MonoBehaviour
{
    private static WinManager _instance;

    public static WinManager Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    public bool hasPlayerWon = false;

    public bool hasWon() 
    {
        return hasPlayerWon;
    }

    public void SetPlayerWon()
    {
        hasPlayerWon = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasWon()) 
        {
            RecordPlayer.Instance.OverwriteSavedList();
            RecordPlayer.Instance.ResetGhost();
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}
