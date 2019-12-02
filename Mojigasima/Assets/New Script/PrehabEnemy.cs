using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrehabEnemy : MonoBehaviour
{

    // メンバ変数宣言
    public GameObject bulletPrefab; // 弾のプレハブ
    public float time; // 経過時間(秒)
    public float speed = 2;
    private bool isInsideCamera;

    // 毎フレーム呼び出されるメソッド


    void Update()

    {
        if (isInsideCamera)
        {
            this.transform.Translate(speed / 50, 0, 0);
            time += Time.deltaTime;
            // １秒ごとに弾を発射
            if (time > 2.0f)
            { // 経過時間が１秒より大きければ経過時間をリセット
                time -= 2.0f;
                GameObject obj;
                obj = Instantiate(bulletPrefab);
                obj.transform.position = transform.position;
                obj.name = "EnemyBullet";
            }
        }
    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    private void OnBecameVisible()
    {
        isInsideCamera = true;
    }
}
