using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inoshishi2 : MonoBehaviour
{
    public float speed = 1;
    private SpriteRenderer sr = null;
    AudioSource audioSource;
    public AudioClip sound1;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (sr.isVisible)
        {
            this.transform.Translate(speed / 100, 0, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Attack")
        {
            audioSource.PlayOneShot(sound1);
        }
    }
}
