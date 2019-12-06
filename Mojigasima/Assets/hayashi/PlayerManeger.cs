using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManeger : MonoBehaviour
{
    public GameObject Player = null;
    public GameObject PlayerAttack = null;
    public static bool attack1 = false;
    public static bool attack2 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (attack1)
        {
            PlayerAttack.SetActive(true);
        }
        if (attack2)
        {
            PlayerAttack.SetActive(false);
        }
    }
}
