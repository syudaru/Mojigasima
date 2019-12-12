using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemydamege : MonoBehaviour
{
    public GameObject howToRead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Attack")
        {
            howToReadScript.time = 0;
            howToRead.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
