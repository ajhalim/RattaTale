using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public TextMeshProUGUI recipeText;
    public Image ingredientImage;
    public TextMeshProUGUI ingredientCountText;

    // Example recipe data structure
    private Dictionary<string, int> currentRecipe = new Dictionary<string, int>();
    
    // Example ingredient data structure
    private Dictionary<string, Sprite> ingredientSprites = new Dictionary<string, Sprite>();

    private void Start()
    {
        // Initialize recipe and ingredient data here
        // recipe (ingredient name, required count)
        currentRecipe.Add("Tomato", 3);
        currentRecipe.Add("Lettuce", 2);

        // ingredient sprites
        ingredientSprites.Add("Tomato", Resources.Load<Sprite>("Tomato"));
        ingredientSprites.Add("Lettuce", Resources.Load<Sprite>("Lettuce"));

        // Update the HUD with the initial recipe
        UpdateHUD();
    }

    void UpdateHUD()
    {
        string recipeString = "Recipe: ";
        if (currentRecipe != null)
        {
            foreach (var ingredient in currentRecipe)
            {
                recipeString += $"{ingredient.Key} x{ingredient.Value} ";
            }
        }

        recipeText.text = recipeString;

        // Update the current ingredient image
        string currentIngredient = GetCurrentIngredient();
        ingredientImage.sprite = ingredientSprites[currentIngredient];

        // Update the count of the current ingredient
        int ingredientCount = GetIngredientCount(currentIngredient);
        ingredientCountText.text = $"x{ingredientCount}";
    }

    string GetCurrentIngredient()
    {
        // Implement logic to get the current ingredient based on player actions
        foreach (var ingredient in currentRecipe)
        {
            return ingredient.Key;
        }
        return null;
    }

    int GetIngredientCount(string ingredient)
    {
        // Implement logic to get the count of the current ingredient based on player actions
        //return Random.Range(0, 5);
        return (1);
    }

    void Update()
    {
        // Call UpdateHUD() whenever the HUD needs to be updated (e.g., in response to player actions)
        UpdateHUD();
    }
}
