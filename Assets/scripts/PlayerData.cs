using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    private Vector2 playerPos;
    //private Quaternion playerRot;

    public PlayerData(Vector2 pos) 
    {
        playerPos = pos;
        //playerRot = rot;
    }

    public Vector2 getPos() 
    {
        return playerPos;
    }

   /* public Quaternion getRot() 
    {
        return playerRot;
    }*/
}
