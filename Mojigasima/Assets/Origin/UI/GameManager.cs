using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject imageObj_Health_1; // プレイヤー残り体力1を示すUI
    public GameObject imageObj_Health_2; // プレイヤー残り体力2を示すUI
    public GameObject imageObj_Health_3; // プレイヤー残り体力3を示すUI

    // プレイヤーの残り体力をUIに適用(PlayerControllerから呼び出される)
    // 引数health : 残り体力
    public void SetPlayerHealthUI(int health)
    {
        // 残り体力によって非表示にすべき体力アイコンを消去する
        if (health == 2)
        { // 体力2になった場合
            Destroy(imageObj_Health_3); // 3つめのアイコンを消去
        }
        else if (health == 1)
        { // 体力1になった場合
            Destroy(imageObj_Health_2); // 2つめのアイコンを消去
        }
        else if (health == 0)
        { // 体力0になった場合
            Destroy(imageObj_Health_1); // 1つめのアイコンを消去
        }
    }
}
