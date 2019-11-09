using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KENDAMAManeger : MonoBehaviour
{
    public GameObject KENDAMA = null;
    public GameObject PlayerAttack = null;
    public GameObject KENDAMAAttack = null;
    public static bool attack1 = false;
    public static bool attack2 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (displayItemManeger.KENDAMA) {

            KENDAMA.SetActive(true);

        }
        if (!PlayerAnimator.normalAttack)
        {
            PlayerAttack.SetActive(false);
        }
        if (attack1)
        {
            KENDAMAAttack.SetActive(true);
        }
        if (attack2)
        {
            KENDAMAAttack.SetActive(false);
        }

    }
}
