using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ingredientScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player" && other.gameObject.transform.childCount < 3)
        {
            transform.SetParent(other.gameObject.transform);
            other.gameObject.GetComponent<playerController>().currentIngredient = tag;
        } else if (other.gameObject.transform.childCount >= 3)
        {
            Debug.Log("Can only carry one ingredient at a time.");
        }
    }
}
