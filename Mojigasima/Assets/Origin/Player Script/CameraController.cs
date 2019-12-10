using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    private Vector3 Ppos;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }
    void LateUpdate()
    {
        Ppos = player.transform.position;
        transform.position = new Vector3(Ppos.x + offset.x,0,Ppos.z + offset.z);
    }
}