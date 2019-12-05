using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI機能の利用に必要なusing文


public class GameManager : MonoBehaviour
{

    // メンバ変数宣言
    public Text text_BossHealth;    // テキスト(ボス残り体力表示用)
    public GameObject imageObj_Health_1; // プレイヤー残り体力1を示すUI
    public GameObject imageObj_Health_2; // プレイヤー残り体力2を示すUI
    public GameObject imageObj_Health_3; // プレイヤー残り体力3を示すUI

    // プレイヤーの残り体力をUIに適用(PlayerControllerから呼び出される)
    // 引数health : 残り体力
    public void SetPlayerHealthUI(int hp)
    {
        // 残り体力によって非表示にすべき体力アイコンを消去する
        if (hp == 2)
        { // 体力2になった場合
            Destroy(imageObj_Health_3); // 3つめのアイコンを消去
        }
        else if (hp == 1)
        { // 体力1になった場合
            Destroy(imageObj_Health_2); // 2つめのアイコンを消去
        }
        else if (hp == 0)
        { // 体力0になった場合
            Destroy(imageObj_Health_1); // 1つめのアイコンを消去
        }
    }
}
