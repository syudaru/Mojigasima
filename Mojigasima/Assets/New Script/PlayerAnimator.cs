using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    Animator animator;
    public float count = 0;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("attack",true);
            Debug.Log("ATTACK");
            count = 0;
        }
        if (count > 100)
        {
            animator.SetBool("attack",false);
        }
    }

}
