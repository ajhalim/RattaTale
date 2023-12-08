using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text playtime;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetFloat("playTime", 90);
        int minutes = Mathf.FloorToInt(PlayerPrefs.GetFloat("playTime") / 60);
        int seconds = Mathf.FloorToInt(PlayerPrefs.GetFloat("playTime") % 60);


        playtime.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
