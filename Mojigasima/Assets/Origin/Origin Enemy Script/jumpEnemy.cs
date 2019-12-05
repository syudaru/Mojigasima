using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpEnemy : MonoBehaviour
{
    public float speed = 1;
    public float jump = 5;
    public float dessous = -5;
    Rigidbody2D rbody;
    private SpriteRenderer sr = null;
    float time = 0;
    // Start is called before the first frame update

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (sr.isVisible)
        {
            this.transform.Translate(speed / 50, 0, 0);
            this.transform.Translate(0, jump / 50, 0);
        }
    }
}