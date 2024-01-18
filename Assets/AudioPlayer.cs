using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip[] sfx;
    public void PlayClip(int element) {
        source.clip = sfx[element];
        source.Play();
    }
}
