using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

public class servingArea : MonoBehaviour
{
    public List<GameObject> servedItems;
    public List<string> masterRecipe;
    public List<string> localRecipe;
    public int recipesMade;

    public string nextScene;

    public float gameTimer = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("numRuns", 0);

        //PlayerPrefs.SetFloat("lastRun", 90);

        //int x = PlayerPrefs.GetInt("numRuns");

        int runCount = PlayerPrefs.GetInt("numRuns") + 1;

        PlayerPrefs.SetInt("numRuns", runCount);

        //Debug.Log(x);
        //Debug.Log(x);

        Debug.Log(PlayerPrefs.GetInt("numRuns"));

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

        if(PlayerPrefs.GetInt("numRuns") > 2)
        {
            Debug.Log(gameTimer);
            float oldPlayTime = PlayerPrefs.GetFloat("playTime");



            oldPlayTime += gameTimer;

            PlayerPrefs.SetFloat("playTime", oldPlayTime);
            PlayerPrefs.SetFloat("lastRun", 90);
            PlayerPrefs.SetInt("numRuns", 0);

            SceneManager.LoadScene(nextScene);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(PlayerPrefs.GetFloat("lastRun"));

        if(PlayerPrefs.GetFloat("lastRun") < gameTimer)
        {
            PlayerPrefs.SetInt("numRuns", 0);
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
        if (localRecipe.Count < 1) {
            recipesMade++;
            Debug.Log("Recipes Made: " + recipesMade);
            localRecipe.AddRange(masterRecipe);
        }

        if (recipesMade >= 1)
        {
            Debug.Log(gameTimer);
            float oldPlayTime = PlayerPrefs.GetFloat("playTime");



            oldPlayTime += gameTimer;

            PlayerPrefs.SetFloat("playTime", oldPlayTime);
            PlayerPrefs.SetFloat("lastRun", gameTimer);


            WinManager.Instance.SetPlayerWon();
            //int runCount = PlayerPrefs.GetInt("numRuns") + 1;

            //PlayerPrefs.SetInt("numRuns", runCount);

            //SceneManager.LoadScene(nextScene);
        }




        //update time
        gameTimer += Time.deltaTime;

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            for (int i = 0; i < localRecipe.Count; i++) 
            {
                Transform ingredient = helperFunctions.FindChildWithTag(collision.gameObject, localRecipe[i]);
                if (ingredient != null) 
                {
                    localRecipe.Remove(ingredient.gameObject.tag);
                    Destroy(ingredient.gameObject);
                   
                    //Debug.Log("Testing localRecipe");

                    //changes scene

                    /* For making sure the contents of localRecipe change, uncomment as needed */
                    // for (int j = 0; j < localRecipe.Count; j++) 
                    // {
                    //     Debug.Log(localRecipe[j]);
                    // }
                }
                
            }
        }
        
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
