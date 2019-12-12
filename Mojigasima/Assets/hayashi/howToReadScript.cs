using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class howToReadScript : MonoBehaviour
{
    public GameObject Enemy = null;
    public Vector3 pos = Vector3.zero;

    public static float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Enemy.transform.position + pos;

        time++;

        if (time > 100)
        {
            Destroy(gameObject);
        }
    }
}
