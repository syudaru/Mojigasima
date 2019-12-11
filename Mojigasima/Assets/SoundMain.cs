using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMain : MonoBehaviour
{

    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
            audioSource.PlayOneShot(sound1);
    }
}
