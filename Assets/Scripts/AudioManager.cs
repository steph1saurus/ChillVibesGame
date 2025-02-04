using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [Header("Music Selection")]
    [SerializeField] private AudioClip[] music;

    [Header("Sounds")]
    [SerializeField] private AudioClip buttonClickSound;
    [SerializeField] private AudioClip puzzleSnapSound;
    [SerializeField] private AudioClip puzzleCompleteSound;

    [Header ("Audio Source")]
    [SerializeField] private AudioSource musicAudioSource;
    [SerializeField] private AudioSource soundFXAudioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayMusic();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayMusic()
    {
        musicAudioSource.clip = music[0];
        musicAudioSource.Play();
    }

    public void ChangeSong()
    {

    }
}
