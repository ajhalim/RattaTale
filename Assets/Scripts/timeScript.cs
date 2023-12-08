using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class timeScript : MonoBehaviour
{
    public float gameTimer = 0f;


    void Update()
    {
        // Update the game timer every frame
        gameTimer += Time.deltaTime;

        // Display the game time in the console (you can modify this part as needed)
        //Debug.Log("Game Time: " + FormatTime(gameTimer));

        //if (Input.GetKeyDown(KeyCode.T))
       // {
       //     Debug.Log("Game Time: " + FormatTime(gameTimer));
       // }




        }

    string FormatTime(float timeInSeconds)
    {
        // Format the time in minutes and seconds
        int minutes = Mathf.FloorToInt(timeInSeconds / 60);
        int seconds = Mathf.FloorToInt(timeInSeconds % 60);

        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Replace "YourTag" with the tag of the object you want to detect collision with
        {
            // Do something when the player collides with the specified object
            Debug.Log("Game Time: " + FormatTime(gameTimer));
            
        }
        Debug.Log(other.name);
    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            // Do something when the player collides with the specified object
            Debug.Log("Game Time: " + FormatTime(gameTimer));
        }
    }*/
}
