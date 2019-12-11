using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    // メンバ変数宣言
    private float time = 0.0f;  // 経過時間
                                // 生成時指定パラメータ
    public float speed;     // 速度
    public float angle;     // 角度(Degree)
    public float limitTime; // 生存時間(秒)

    // 毎フレーム呼び出されるメソッド
    void Update()
    {
        // -----移動処理-----
        // 変数宣言
        float rad;      // 角度(Radian)←計算に使用する
        Vector2 vec;    // 移動量ベクトル(x方向, y方向)
        float move_x, move_y;   // x方向、y方向それぞれの移動量格納用

        // 角度変数angleをラジアン値に変換して変数radに格納
        rad = angle * Mathf.Deg2Rad;

        // 速度と角度から移動量を算出
        move_x = Mathf.Cos(rad) * speed * Time.deltaTime; // x方向の移動量
        move_y = Mathf.Sin(rad) * speed * Time.deltaTime; // y方向の移動量
        vec = new Vector2(move_x, move_y); // 変数vecを初期化しつつ、xとyの移動量をセット

        // 変数vec分だけ自オブジェクトを移動
        transform.Translate(vec);

        // -----寿命処理-----
        // 前回のUpdate実行から経過した時間をtimeに加算
        time += Time.deltaTime;
        // 消滅処理
        if (time > 5.0f)
        { // 弾の経過時間が５秒より大きければ
            Destroy(gameObject);
        }
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			Destroy(gameObject);
		}
	}
}