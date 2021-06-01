using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volumeAdjustments : MonoBehaviour
{
    public AudioSource AudioSource;

    private float musicVolume = 0.15f;


    // Update is called once per frame
    void Update()
    {
        AudioSource.volume = musicVolume;
    }

    public void updateVolume(float volume){
        musicVolume = volume;
    }
}
