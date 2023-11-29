using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catAI : MonoBehaviour
{
    public GameObject player;
    public float speed;
    private float distance;
    private float clockTime;

    // Start is called before the first frame update
    void Start()
    {
        speed = 1;
        distance = 0;
        clockTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);

        //move slowly for the first 3 steps, and stop 1 clock, jump towards the player quickly on the next clock

        clockTime += Time.deltaTime;

        if (clockTime < 3)
        {
            speed = 1;
        }
        else if (3 <= clockTime && clockTime <= 4)
        {
            speed = 0;
        }
        else if (4 < clockTime && clockTime < 4.15)
        {
            speed = 15;
        }
        else
        {
            clockTime = 0;
        }
    }
}