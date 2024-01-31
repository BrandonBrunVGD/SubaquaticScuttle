using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    #region Singleton
    
    public static AudioManager Instance;
    private void Awake() {
        if (Instance == null) {
            Instance = this;
        }
    }

    #endregion

    [SerializeField] private AudioSource audioSource;

    public void PlaySFX(AudioClip audioClip) {
        audioSource.clip = audioClip;
        audioSource.Play();
    }

}
