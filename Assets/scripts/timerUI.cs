using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timerUI : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    public void UpdateTimer(float time)
    {
        timerText.text = "Time: " + Mathf.Max(0, Mathf.Ceil(time));
    }
}
