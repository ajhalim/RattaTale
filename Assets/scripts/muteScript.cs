using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muteScript : MonoBehaviour
{
    //public AudioSource audioSource;
    //public Text buttonText; // The text component on the button to change the label
    public bool muteStatus = false;
    public float thing = 0;
    //private bool isMuted = false;

    public void ToggleMute()
    {
        if (muteStatus == false)
        {
            muteStatus = true;
            thing = 0;


        }
        else
        {
            muteStatus = false;
            thing = 1;
        }
        PlayerPrefs.SetFloat("GameVolume", thing);
        //audioSource.volume = PlayerPrefs.GetFloat("GameVolume");
        //PlayerPrefs.SetFloat("GameVolume", audioSlider.value);

        //UpdateButtonText();
    }
}
