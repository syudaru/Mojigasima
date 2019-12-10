using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCopy : MonoBehaviour
{

    // 変数宣言
    private float speed = 3.0f;
    private float time = 0.0f;

    // 起動時に１回だけ呼び出されるメソッド
    void Start()
    {
    }

    // 毎フレーム呼び出されるメソッド
    void Update()
    {
        Vector3 pos = transform.position;
        // 指定した速度で直進する
        pos.y -= speed * Time.deltaTime;
        transform.position = pos;

        // 寿命処理
        time += Time.deltaTime;
        if (time > 5.0f)
        {
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