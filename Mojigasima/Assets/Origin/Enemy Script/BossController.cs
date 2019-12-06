using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{

    // メンバ変数宣言
    public GameObject bulletPrefab; // 弾のプレハブ
    public int health;  // 体力
    private float time; // 経過時間(秒)
    public GameObject playerObj;

    // 毎フレーム呼び出されるメソッド
    void Update()
    {
        // 経過時間をカウント
        time += Time.deltaTime;

        // -----弾発射処理-----
        // １秒ごとに弾を発射
        if (time > 1.0f)
        { // 経過時間が１秒より大きければ
          // 経過時間をリセット
            time -= 1.0f;

            // GameObject型ローカル変数を宣言
            GameObject obj;
            // 弾プレハブのインスタンスを生成し、変数objに格納
            obj = Instantiate(bulletPrefab);
            // 弾インスタンスの座標にボスの座標をセット
            obj.transform.position = transform.position;
            // インスタンスのオブジェクト名を変更(自弾と区別するため)
            obj.name = "EnemyBullet";
            // プレイヤーへの角度を計算
            float playerAng;    // プレイヤーへの角度
            Vector2 target;     // プレイヤーの相対座標
            target = playerObj.transform.position - transform.position; // 相対座標を計算
            playerAng = Mathf.Atan2(target.y, target.x); // 相対座標から角度(Radian)を計算
            playerAng *= Mathf.Rad2Deg; // Radian角度をDegree角度に変換
                                        // 弾のパラメータをセット
            obj.GetComponent<Bullet>().speed = 4.0f;        // 速度
            obj.GetComponent<Bullet>().angle = playerAng;       // 角度
            obj.GetComponent<Bullet>().limitTime = 5.0f;    // 生存時間
                                                            // 弾の色を変更
            obj.GetComponent<SpriteRenderer>().color = Color.magenta; // マゼンタ
        }
    }
    float GetAngleToPlayer()
    {
        // 変数宣言
        float playerAng;    // プレイヤーへの角度
        Vector2 target;     // プレイヤーの相対座標

        // 角度計算処理
        target = playerObj.transform.position - transform.position; // 相対座標を計算
        playerAng = Mathf.Atan2(target.y, target.x); // 相対座標から角度(Radian)を計算
        playerAng *= Mathf.Rad2Deg; // Radian角度をDegree角度に変換

        // 計算した角度情報を呼び出し元に返す
        return playerAng;
    }
}