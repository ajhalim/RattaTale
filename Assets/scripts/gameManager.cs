using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public recipeUI recipeUI;

    public float recipeChangeInterval = 10f;
    private float timer = 0f;

    void Start()
    {
        // Initialize and set up your game state

        // Example: Set the initial recipe
        SetCurrentRecipe("Pasta");
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= recipeChangeInterval)
        {
            ChangeRecipe();
        }
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
