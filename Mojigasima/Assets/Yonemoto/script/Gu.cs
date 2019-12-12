using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gu : MonoBehaviour
{
	public float speed = 1.0f;
	public int hp = 3;
	public GameObject bulletObject = null;
	public float bulletInterval = 5.0f;
	public float intervalTime = 0;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		//5秒ごとに弾を発射する
		intervalTime -= Time.deltaTime;
		if (intervalTime < 0.0f)
		{
			Vector3 bulletPosition = transform.position + new Vector3(1.0f, 0, 0);
			Instantiate(bulletObject, bulletPosition, Quaternion.identity);
			intervalTime = bulletInterval;
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "PlayerAttack")
		{
			hp -= 1;
			if (hp <= 0)
			{
				Destroy(gameObject);
			}
		}
	}
}
