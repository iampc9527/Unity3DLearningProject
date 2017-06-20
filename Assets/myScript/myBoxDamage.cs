using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myBoxDamage : MonoBehaviour {
	public int damageNumber = 1;
	public float showUpDelay = 0.0f;
	public bool randomShowUp = false;
	public float randomMax = 0.0f;

	private bool started = false;
	private float startTime = 0;
	private int currentDamage = 0;
	private SpriteRenderer mySpriteRenderer;
	private Animator myAnimator;

	// Use this for initialization
	void Awake () {
		mySpriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
		myAnimator = gameObject.GetComponent<Animator> ();
		mySpriteRenderer.enabled = false;
		myAnimator.enabled = false;
		startTime = Time.time;

		if (randomShowUp) {
			showUpDelay = Random.Range (0.0f, randomMax);
		}
	}

	void Start () {
	}

	void FixedUpdate () {
		if (started) {
			mySpriteRenderer.enabled = true;
			myAnimator.enabled = true;
			if (mySpriteRenderer.color.a > 0.9f) {
				currentDamage = damageNumber;
			} else {
				currentDamage = 0;
			}
			return;
		}

		if (Time.time - startTime > showUpDelay ) {
			started = true;
		}
	}

	// Update is called once per frame
	void Update () {

	}


	//Do damage when playe touch the box area
	void OnTriggerStay2D(Collider2D other) {
		if (other.gameObject.tag == "Player" && currentDamage > 0) {
			other.gameObject.GetComponent<myCharacter> ().changeHealth (-currentDamage);
		}
	}

}
