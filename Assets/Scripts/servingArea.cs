using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class servingArea : MonoBehaviour
{
    public List<GameObject> servedItems;
    public List<string> masterRecipe;
    public List<string> localRecipe;
    public int recipesMade;
    // Start is called before the first frame update
    void Start()
    {
        servedItems = new List<GameObject>();
        masterRecipe = new List<string>
        {
            "Tomato",
            "Spaghetti",
            "Cheese"
        };
        localRecipe = new List<string>();
        localRecipe.AddRange(masterRecipe);
        recipesMade = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (localRecipe.Count < 1) {
            recipesMade++;
            Debug.Log("Recipes Made: " + recipesMade);
            localRecipe.AddRange(masterRecipe);
            for (int j = 0; j < localRecipe.Count; j++) 
                    {
                        Debug.Log(localRecipe[j]);
                    }
        }
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            for (int i = 0; i < localRecipe.Count; i++) 
            {
                // Debug.Log(collision.gameObject.transform.Find(localRecipe[i]));

                Transform ingredient = collision.gameObject.transform.Find(localRecipe[i]);
                if (ingredient != null) 
                {
                    localRecipe.Remove(ingredient.gameObject.tag);
                    Destroy(ingredient.gameObject);
                    // for (int j = 0; j < localRecipe.Count; j++) 
                    // {
                    //     Debug.Log(localRecipe[j]);
                    // }
                    
                }
            }
        }
        
    }
}
