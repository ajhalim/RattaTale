using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordPlayer : MonoBehaviour
{
    public List<PlayerData> playerStateList;
    public GameObject playerObj;
    public GameObject ghostObj;
    private bool recording = true;
    private int currFrame = 0;


    public void SavePlayerState() 
    {
        playerStateList.Add(new PlayerData(playerObj.transform.position));
    }

    public void ReadPlayerState() 
    {
        if (!ghostObj.activeSelf) 
        {
            ghostObj.SetActive(true);
        }

        if (currFrame < playerStateList.Count) 
        {
            ghostObj.transform.position = playerStateList[currFrame].getPos();
            //ghostObj.transform.rotation = playerStateList[currFrame].getRot();
            currFrame++;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        playerStateList = new List<PlayerData>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            recording = false;
        }

        if (recording)
        {
            SavePlayerState();
        }
        else 
        {
            ReadPlayerState();
        }
    }
}
