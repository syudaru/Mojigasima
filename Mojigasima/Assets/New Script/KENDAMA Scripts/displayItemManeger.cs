using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayItemManeger : MonoBehaviour
{
    public GameObject MoziMA = null;
    public GameObject MoziDA = null;
    public GameObject MoziKE = null;
    public GameObject MoziNN = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fieldItemMA.displayMA)
        {
            MoziMA.SetActive(true);
        }
        if (fieldItemKE.displayKE)
        {
            MoziKE.SetActive(true);
        }
        if (fieldItemDA.displayDA)
        {
            MoziDA.SetActive(true);
        }
        if (fieldItemNN.displayNN)
        {
            MoziNN.SetActive(true);
        }
    }
}
