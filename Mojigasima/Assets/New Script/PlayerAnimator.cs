using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    Animator animator;
    public float count = 100;
    public static bool normalAttack = true;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (normalAttack) {
            count++;
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                animator.SetBool("PlayerAttack", true);
                count = 0;
                PlayerManeger.attack1 = true;
                PlayerManeger.attack2 = false;
            }
            if (count >= 100)
            {
                animator.SetBool("PlayerAttack", false);
                PlayerManeger.attack1 = false;
                PlayerManeger.attack2 = true;
            }
        }
    }

}
