using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    float camx = -10000; //カメラの移動限界座標（左）
    private Vector3 Ppos;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }
    void LateUpdate()
    {
        Ppos = player.transform.position;
        transform.position = new Vector3(Mathf.Clamp( Ppos.x + offset.x,camx,-1),0,Ppos.z + offset.z);
    }
}