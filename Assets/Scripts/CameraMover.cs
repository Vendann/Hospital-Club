using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
	public Transform player;
	private Vector3 pos;

	void Start()
	{
		player = GameObject.Find("Player").transform;
	}

	void LateUpdate()
	{
		pos = player.position;
		pos.y = 13f;
		this.transform.position = pos;
	}
}
