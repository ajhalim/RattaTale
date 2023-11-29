using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class helperFunctions
{
    // Cycles through all children of the provided parent and finds the 
    // first child with the specified tag; returns the TRANSFORM of the child (not GameObject)
    public static Transform FindChildWithTag(GameObject parent, string tag) 
    {  
        for (int i = 0; i < parent.transform.childCount; ++i)
        {
            Transform child = parent.transform.GetChild(i);
            if (child.gameObject.tag == tag) 
            {
                return child;
            }
        }
    
        return null;
    }
}
