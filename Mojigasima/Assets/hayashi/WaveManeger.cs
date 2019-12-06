using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaveManeger : MonoBehaviour
{
    // 敵機のプレハブ Wave を格納する配列
    public GameObject[] waves;
    // 現在の敵機のインデックス
    private int currentWave;
    // Start is called before the first frame update
    private IEnumerator Start()
    {
        // 配列が空であれば（Wave が存在しなければ）
        if (waves.Length == 0)
        {
            // コルーチン終了
            yield break;
        }
        while (true)
        {
            //  配列に格納されたプレハブ Wave からインスタンスを生成して wave に格納
            GameObject wave = (GameObject)Instantiate(waves[currentWave],
                transform.position, Quaternion.identity);

            // 敵機 wave を Emitter の子要素にする
            wave.transform.parent = transform;

            // Emitter の子要素の敵機 wave の数が 0 でなければ
            while (wave.transform.childCount != 0)
            {
                // 削除されるまで待機する
                yield return new WaitForEndOfFrame();
            }

            // 敵機 wave の削除
            Destroy(wave);

            // 現在の敵機のインデックスに加算し、配列に格納された数以上になれば
            if (waves.Length <= ++currentWave)
            {
                Debug.Log("Gameclear");
                SceneManager.LoadScene("scene game clear");
                //currentWave = 0;
            }
        }
    }
}
