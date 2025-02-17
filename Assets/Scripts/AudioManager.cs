using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    [Header("Music Selection")]
    [SerializeField] private AudioClip[] music;
    [SerializeField] private Button harmonyInHaze;
    [SerializeField] private Button lostInYou;
    [SerializeField] private Button beMoreChill;
    [SerializeField] private Button noBoundaries;
    [SerializeField] private Button starlightRef;

    [Header("Sounds")]
    [SerializeField] private AudioClip buttonClickSound;
    [SerializeField] private AudioClip puzzleSnapSound;
    [SerializeField] private AudioClip puzzleCompleteSound;

    [Header ("Audio Source")]
    [SerializeField] private AudioSource musicAudioSource;
    [SerializeField] private AudioSource soundFXAudioSource;
    
    void Start()
    {
        
        PlayMusic();
        
    }

    void Update()
    {
        harmonyInHaze.onClick.AddListener(delegate { ChangeMusic(music[0]); });
        lostInYou.onClick.AddListener(delegate { ChangeMusic(music[1]); });
        beMoreChill.onClick.AddListener(delegate { ChangeMusic(music[2]); });
        noBoundaries.onClick.AddListener(delegate { ChangeMusic(music[3]); });
        starlightRef.onClick.AddListener(delegate { ChangeMusic(music[4]); });
    }

    
    public void PlayMusic()
    {
        musicAudioSource.clip = music[0];
        musicAudioSource.Play();
    }

    public void OnPuzzleComplete()
    {
        soundFXAudioSource.PlayOneShot(puzzleCompleteSound);
    }

    public void OnButtonClick()
    {
        soundFXAudioSource.PlayOneShot(buttonClickSound);
    }


    public void OnPuzzleSnap()
    {
        soundFXAudioSource.PlayOneShot(puzzleSnapSound);
    }

    public void ChangeMusic(AudioClip music)
    {
        musicAudioSource.Stop();
        musicAudioSource.clip = music;
        musicAudioSource.Play();
    }
   
}
