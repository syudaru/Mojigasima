using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset;
    // Use this for initialization
    void Start()
    {
        this.player = GameObject.Find("Player");
        offset = transform.position - player.transform.position;
    }
    void Update()
    {
        //新しいトランスフォームの値を代入する
        transform.position = player.transform.position + offset;
    }
}
