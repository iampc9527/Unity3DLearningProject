using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myChaseScript : MonoBehaviour {
	public GameObject target;
	public float chaseSpeed = 1.0f;

	private Vector3 endPostion;
	// Use this for initialization

	void Start () {
		
	}

	void FixedUpdate () {
		endPostion = target.transform.position;

		float step = Time.deltaTime * chaseSpeed;
		gameObject.transform.position = Vector3.MoveTowards (gameObject.transform.position, endPostion, step);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
