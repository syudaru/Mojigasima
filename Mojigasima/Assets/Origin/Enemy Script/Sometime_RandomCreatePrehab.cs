using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometime_RandomCreatePrehab : MonoBehaviour
{
    public GameObject newPrehab;
    public float intervalSec = 1;

    void Start()
    {
        InvokeRepeating("CreatePrehab", intervalSec, intervalSec);
    }

    // Update is called once per frame
    void CreatePrehab()
    {
        Vector3 area = GetComponent<SpriteRenderer>().bounds.size;
        Vector3 newPos = this.transform.position;
        newPos.x += Random.Range(-area.x / 2, area.x / 2);
        newPos.y += Random.Range(-area.y / 2, area.y / 2);

        GameObject newGameObject = Instantiate(newPrehab) as GameObject;
        newGameObject.transform.position = newPos;
    }
}
