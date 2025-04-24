using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger1 : MonoBehaviour
{
    AudioSource source;
    Collider soundTrigger;
    public AudioClip[] birdSounds;
    //public int count = 0;
    [Range(0.1f, 0.5f)]
    public float pitchChangeMultiplier = 0.2f;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider>();
    }
    
    private void OnTriggerEnter(Collider collider)
    {

        source.clip = birdSounds[Random.Range(0, birdSounds.Length)];
        source.pitch = Random.Range(1 - pitchChangeMultiplier, 1 + pitchChangeMultiplier);
        source.Play();
        //count++;
    }

    private void OnTriggerExit(Collider collider)
    {
        source.Stop();
    }
}
