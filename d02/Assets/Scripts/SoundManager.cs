using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource audioSource;
    public static SoundManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip sound)
    {
        audioSource.PlayOneShot(sound);
    }
}
