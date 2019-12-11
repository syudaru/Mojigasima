using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class title : MonoBehaviour
{
    public FadeImage fade;

    private bool firstPush = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame


    public void PressStart()
    {
        Debug.Log("Press Start!");
        if (!firstPush)
        {
            if (fade != null)
            {
                fade.StartFadeOut();
                firstPush = true;
            }
        }
    }
}
