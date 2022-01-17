using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{

    public AudioSource backGroundMusic;
    public AudioSource buttonClick;
    
    // Start is called before the first frame update
    public void ButtonClick()
    {
        buttonClick.Play();
    }

    public void PlayMusic()
    {
        backGroundMusic.Play();
    }
}
