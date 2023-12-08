using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordPlayer : MonoBehaviour
{
    private static RecordPlayer _instance;

    public static RecordPlayer Instance { get { return _instance; } }

    private void Awake() 
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else 
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // list that saves PlayerData per frame
    public List<PlayerData> playerStateList;

    // list that saves ghost movements after completed level run
    public List<PlayerData> savedStateList;


    public GameObject playerObj;
    public GameObject ghostObj;
    private int currFrame = 0;
    private Vector2 origin = new Vector2(0, 0);
    private Vector2 offscreen = new Vector2(-75, 0);
    private bool levelCompleted = false;
    private bool spawnGhost = false;
    private float timeDelay = 3f;

    // Function that resets the current frame counter back to 0 and clears the current list of PlayerData
    // >>> IMPORTANT <<<
    // When implementing a GAME OVER CONDITION, use this function by itself before reloading scene, DO NOT USE with OverwriteSavedList()
    public void ResetGhost() 
    {
        levelCompleted = true;
        currFrame = 0;
        spawnGhost = false;
        playerStateList.Clear();
    }

    // Function that records layer's position and rotation into list every frame
    // USE IN UPDATE
    public void SavePlayerState() 
    {
        playerStateList.Add(new PlayerData(playerObj.transform.position, playerObj.transform.rotation));
    }

    //Function that reads layer's position and rotation into list every frame <summary>
    // USE IN UPDATE

    public void ReadPlayerState() 
    {
        if (currFrame < savedStateList.Count) 
        {
            ghostObj.transform.position = savedStateList[currFrame].getPos();
            ghostObj.transform.rotation = savedStateList[currFrame].getRot();
            currFrame++;
        }
    }

    // Saves the playerData list for subsequent run and clears the previous list
    // >>> IMPORTANT <<<
    // When implementing a WIN CONDITION, use this function BEFORE and IN TANDEM with ResetGhost() before reloading scene
    public void OverwriteSavedList()
    {
            savedStateList.Clear();
            for (int i = 0; i < playerStateList.Count; i++)
            {
                savedStateList.Add(playerStateList[i]);
            }
            playerStateList.Clear();
    }

    // Start is called before the first frame update
    void Start()
    {
        playerStateList = new List<PlayerData>();
        savedStateList = new List<PlayerData>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerObj == null) 
        {
            playerObj = GameObject.FindWithTag("Player");
        }

        if (ghostObj == null) 
        {
            ghostObj = GameObject.FindWithTag("Ghost");
        }

        SavePlayerState();

        if (!spawnGhost) 
        {
            timeDelay -= Time.deltaTime;
            if (timeDelay <= 0) 
            {
                spawnGhost = true;
                timeDelay = 3f;
            }
        }

        if (spawnGhost && levelCompleted) 
        {
            ReadPlayerState();
        }
    }
}
