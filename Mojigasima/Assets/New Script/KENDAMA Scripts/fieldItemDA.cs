﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fieldItemDA : MonoBehaviour
{
    public GameObject MoziDA = null;
    public static bool displayDA = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //衝突したときに呼び出される
    public void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
        displayDA = true;
    }
}
