using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCount : MonoBehaviour
{
	public static TimeCount singleton;
	//　トータル制限時間
	public float totalTime;
	//　制限時間（分）
	[SerializeField]
	private static float minute = 1f;
	//　制限時間（秒）
	[SerializeField]
	private static float seconds = 0f;
	//　前回Update時の秒数
	private float oldSeconds;
	private Text timerText;
	public string scenename;

	void Start()
	{
		totalTime = minute * 60 + seconds;
		oldSeconds = 0f;
		timerText = GetComponentInChildren<Text>();
		// スクリプトが設定されていなければゲームオブジェクトを残しつつスクリプトを設定
		if (singleton == null)
		{
			DontDestroyOnLoad(timerText);
		}
		// 既にTimeCountスクリプトがあればこのシーンの同じゲームオブジェクトを削除
		else
		{
			Destroy(timerText);
		}
	}

	void Update()
	{
		//　制限時間が0秒以下なら何もしない
		if (totalTime <= 0f)
		{
			return;
		}
		//　一旦トータルの制限時間を計測；
		totalTime = minute * 60 + seconds;
		totalTime -= Time.deltaTime;

		//　再設定
		minute = (int)totalTime / 60;
		seconds = totalTime - minute * 60;

		//　タイマー表示用UIテキストに時間を表示する
		if ((int)seconds != (int)oldSeconds)
		{
			timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
		}
		oldSeconds = seconds;
		//　制限時間以下になったらコンソールに『制限時間終了』という文字列を表示する
		if (totalTime <= 0)
		{
			Debug.Log("制限時間終了");
		}
		if (totalTime == 0)
		{
			SceneManager.LoadScene("scene game over");
			//SceneManager.LoadScene(scenename);
		}
	}
}
