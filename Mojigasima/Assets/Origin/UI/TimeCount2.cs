using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCount2 : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		if (TimeCount.totalTime <= 55)
		{
			TimeCount time = new TimeCount();
			time.GetTimeCount();
		}
	}
}