using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inoshishi : MonoBehaviour
{
    public int maxcount = 50;
    private int count = 0;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
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
        }
    }
}
