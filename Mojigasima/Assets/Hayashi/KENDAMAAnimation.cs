using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KENDAMAAnimation : MonoBehaviour
{
    Animator animator;
    public GameObject KENDAMA = null;
    public float count = 100;
    public GameObject Player = null;
    public Vector3 pos = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + pos;
        count++;
        if (displayItemManeger.KENDAMA)
        {
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetBool("KENDAMAAttack", true);
                Debug.Log("KENDAMAATTACK");
                count = 0;
                KENDAMAManeger.attack1 = true;
                KENDAMAManeger.attack2 = false;
            }
            if (count >= 200)
            {
                animator.SetBool("KENDAMAAttack", false);
                KENDAMAManeger.attack1 = false;
                KENDAMAManeger.attack2 = true;
            }
        }
    }
}
