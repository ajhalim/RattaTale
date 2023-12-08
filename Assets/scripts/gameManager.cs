using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    //public HUDManager HUDManager;

    //public float recipeChangeInterval = 10f;
    public float initialTime = 60f;
    private float timer = 0f;
    private float score = 0f;

    void Start()
    {
        // Initialize and set up your game state
        timer = initialTime;
        // Example: Set the initial recipe
        //SetCurrentRecipe("Pasta");
        //HUDManager.updateScore(score);
    }

    void Update()
    {
        timer -= Time.deltaTime;

        //HUDManager.UpdateTimer(timer);

        if (timer <= 0f)
        {
            //End the game or something
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            score++;
            //HUDManager.updateScore(score);
        }
    }
}
