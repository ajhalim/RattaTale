using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public recipeUI recipeUI;
    public timerUI timerUI;
    public scoreUI scoreUI;

    //public float recipeChangeInterval = 10f;
    public float initialTime = 60f;
    private float timer = 0f;
    private float score = 0f;

    void Start()
    {
        // Initialize and set up your game state
        timer = initialTime;
        // Example: Set the initial recipe
        SetCurrentRecipe("Pasta");
        scoreUI.updateScore(score);
    }

    void Update()
    {
        timer -= Time.deltaTime;

        timerUI.UpdateTimer(timer);

        if (timer <= 0f)
        {
            //End the game or something
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            score++;
            scoreUI.updateScore(score);
        }
        /*
        timer += Time.deltaTime;
        
        if (timer >= recipeChangeInterval)
        {
            ChangeRecipe();
        }
        */
    }

    void ChangeRecipe()
    {
        string[] recipes = { "Pizza", "Sushi", "Burger" };
        string nextRecipe = recipes[Random.Range(0, recipes.Length)];

        SetCurrentRecipe(nextRecipe);

        timer = 0f;
    }

    void SetCurrentRecipe(string recipeName)
    {
        recipeUI.UpdateRecipeUI(recipeName);
        // Add logic to handle other aspects of the game based on the new recipe
    }
}
