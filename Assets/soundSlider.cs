using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class soundSlider : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider audioSlider;

    //private const string PlayerPrefsVolumeKey = "GameVolume";

    private void Start()
    {
        // Initialize the slider's value to the current audio source volume.
        //audioSlider.value = audioSource.volume;
        PlayerPrefs.SetFloat("GameVolume", audioSlider.value);
        PlayerPrefs.SetFloat("playTime", 0);
        PlayerPrefs.SetFloat("lastRun", 9999999999);

        audioSlider.value = PlayerPrefs.GetFloat("GameVolume");
    }

    public void OnVolumeChange()
    {
        // Called when the slider value changes.
        audioSource.volume = audioSlider.value;

        PlayerPrefs.SetFloat("GameVolume", audioSlider.value);

        audioSource.volume = PlayerPrefs.GetFloat("GameVolume");
    }

}


//PlayerPrefs.SetFloat("playTime", 0);