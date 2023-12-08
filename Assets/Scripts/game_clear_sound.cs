using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_clear_sound : MonoBehaviour
{

    public AudioClip soundEffect;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = soundEffect;
    }

    public void sound()
    {
        audioSource.Play();
    }

    public void home()
    {
        SceneManager.LoadScene(0);
    }

    void Update()
    {

    }
}
