using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public void updateScore(float score)
    {
        scoreText.text = "Score: " + score;
    }
}
