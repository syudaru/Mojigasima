using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOut : MonoBehaviour
{
    GameObject mainCamObj;
    Camera cam;

    void Start()
    {
        mainCamObj = GameObject.FindGameObjectWithTag("MainCamera");
        cam = mainCamObj.GetComponent<Camera>();
    }
    void OnBecameInvisible()

    {

        enabled = false;

    }

    void OnBecameVisible()

    {

        enabled = true;

    }
}

