using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myController : MonoBehaviour {
	private myCharacter character;
	private Rigidbody2D playerRigidbody2d;
	private Vector2 jumpForce;
	// Use this for initialization
	void Awake() {
		character = GetComponent<myCharacter> ();
		playerRigidbody2d = GetComponent<Rigidbody2D> ();
		Debug.Log ("myController Awake");
	}

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}
	


	void FixedUpdate() {
		/*
		 excuted every fix frame period
		 */
		motionUpdate ();

	}



	void motionUpdate() {
		
		float horizonMove = Input.GetAxis ("Horizontal");

		character.move (horizonMove);

		if (Input.GetButtonDown("Fire1")) {
			character.roll ();
		}

		if (Input.GetKey ("right")) {
			character.move(5.0f);
		}

		if (Input.GetKeyUp ("right")) {
			character.move(-0.01f);
		}

		if (Input.GetKey ("left")) {
			character.move(-5.0f);
		}
			
		if (Input.GetKeyUp ("left")) {
			character.move(0.01f);
		}

		if (Input.GetKeyDown("space") || Input.GetButtonDown("Jump")) {  
			character.jump();
		}

	}
}
