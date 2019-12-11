﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTriggerObject : MonoBehaviour
{
    private string playerTag = "Player";
    private bool isOn = false;
    private bool callFixed = false;

    /// <summary>
    /// プレイヤーが上に乗っているかどうか
    /// </summary>
    /// <returns><c>true</c>, if player on was ised, <c>false</c> otherwise.</returns>
    public bool IsPlayerOn()
    {
        return isOn;
    }

    private void FixedUpdate()
    {
        callFixed = true;
    }

    private void LateUpdate()
    {
        if (callFixed)
        {
            //フラグを元に戻します
            isOn = false;
            callFixed = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == playerTag)
        {
            //プレイヤーの下から４分の１が範囲内にいる時乗っているとみなします
            if (collision.transform.position.y - (collision.bounds.size.y / 4.0f) > transform.position.y)
            {
                isOn = true;
            }
        }
    }
}
