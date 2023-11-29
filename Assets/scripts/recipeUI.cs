using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class recipeUI : MonoBehaviour
{
    public TextMeshProUGUI recipeText;

    // Other variables for recipe data goes here

    void Start()
    {
        UpdateRecipeUI("Pasta");
    }

    public void UpdateRecipeUI(string recipeName)
    {
        recipeText.text = "Recipe: " + recipeName;
    }
}
