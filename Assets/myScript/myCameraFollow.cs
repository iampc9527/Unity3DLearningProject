using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myCameraFollow : MonoBehaviour {
	public GameObject target;
	public float cameraInfrontDistance = 3.0f;
	public float cameraZposition = -10;
	public float cameraMoveSpeed = 1;

	private int targetFaceRight;
	private Vector3 endPosition;
	// Use this for initialization
	void Awake(){
		
	}

	void Start(){
		float targetFace = target.GetComponent<myCharacter> ().getCurrentSpeedDirection () ;
		endPosition = new Vector3 (target.transform.position.x + targetFace * cameraInfrontDistance, target.transform.position.y, cameraZposition);
		gameObject.transform.position = endPosition;
	}
	
	// Update is called once per frame
	void Update(){


		float targetFace = target.GetComponent<myCharacter> ().getCurrentSpeedDirection () ;
		endPosition = new Vector3 (target.transform.position.x + targetFace * cameraInfrontDistance, target.transform.position.y, cameraZposition);

		float step = cameraMoveSpeed * Time.deltaTime;
		gameObject.transform.position = Vector3.MoveTowards (gameObject.transform.position, endPosition, step);

	}
}
