using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nezumi : MonoBehaviour
{
    public float speed = 1;
    bool flipFlag = false;
    public int maxcount = 50;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Translate(speed / 100, 0, 0);
        count = count + 1;
        if (count >= maxcount)
        {
            this.transform.Rotate(0, 0, 180);
            count = 0;
            flipFlag = !flipFlag;
            this.GetComponent<SpriteRenderer>().flipY = flipFlag;
        }
    }
}

