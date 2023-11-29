using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class PlayerController : MonoBehaviour
{

    private float gameTimer = 0f;
    public float moveSpeed = 5f;

    public Rigidbody2D player;

    Vector2 movement;

    private void Start()
    {

    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        gameTimer += Time.deltaTime;
        //Debug.Log("Game Time: " + FormatTime(gameTimer));
    }

    private void FixedUpdate()
    {
        player.MovePosition(player.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    string FormatTime(float timeInSeconds)
    {
        // Format the time in minutes and seconds
        int minutes = Mathf.FloorToInt(timeInSeconds / 60);
        int seconds = Mathf.FloorToInt(timeInSeconds % 60);

        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void OnTriggerStay2D(Collider2D other)
    {

        string thing = other.gameObject.name;
        if(thing == "cheese")
        {
            Debug.Log("Game Time: " + FormatTime(gameTimer));
        }
    }   
}



