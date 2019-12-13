using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuAttackBoss : MonoBehaviour
{
	public float speed = 0.1f;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		//Hierarchy WindowからPlayerTagの付いたアクティブ状態のオブジェクトを探して二点間の距離を取得して追う
		GameObject target = GameObject.FindWithTag("Player");
		float following = Time.deltaTime * speed;
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, following);
		//3秒後にオブジェクトが消える
		Destroy(this.gameObject, 3.0f);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			Destroy(gameObject);
		}
	}
}