using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] AudioSource BgmAudio;
    [SerializeField] AudioSource SfxAudio;
    public AudioClip bgm;

    private void Start()
    {
        BgmAudio.clip = bgm;
        BgmAudio.Play();
    }
}
