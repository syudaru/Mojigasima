using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpEnemy : MonoBehaviour
{
    public float speed = 1;
    public float jump = 5;
    Rigidbody2D rbody;
    private SpriteRenderer sr = null;
    float time = 0;
    AudioSource audioSource;
    public AudioClip sound2;
    Rigidbody2D rb2d;

    // Start is called before the first frame update

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sr.isVisible)
        {
            this.transform.Translate(speed / 50, 0, 0);
            this.transform.Translate(0, jump / 50, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Attack")
        {
            audioSource.PlayOneShot(sound2);
        }
    }
}