using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal: MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D hit)
	{
		if (hit.collider.tag == "Player")
		{
			Time.timeScale = 0;
			print("level completed");
		}
	}
}
