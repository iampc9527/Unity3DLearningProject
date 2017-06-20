using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReBootRobot : MonoBehaviour {

	public bool rebootMode = true;
	public int rebootHeath = 50;
	public int damage = -1000;

	private Animator myAnimator;
	// Use this for initialization
	void Awake() {
		myAnimator = gameObject.GetComponent<Animator> ();
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "BrokenRobot") {
			myAnimator.SetBool ("ObjectInside", true);

			Debug.Log ("detected robot enter");
			if (rebootMode) {
				other.GetComponent<myCharacter> ().backToLive (rebootHeath);
				Debug.Log ("reboot");

			} else {
				other.GetComponent<myCharacter> ().changeHealth (damage);
				Debug.Log ("changing health");
			}
		}
	}

	void OnTriggerExit2D(Collider2D other) { 
		if (other.tag == "BrokenRobot") {
			myAnimator.SetBool ("ObjectInside", false);
		}
	}
}
