using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myGroundCheck : MonoBehaviour {
	[SerializeField] private LayerMask m_WhatIsGround;                  // A mask determining what is ground to the character

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//parent call this function to determine if it is on ground or not
	public bool groundCheck() {

		Collider2D[] colliders = Physics2D.OverlapCircleAll(gameObject.transform.position, gameObject.GetComponent<CircleCollider2D>().radius, m_WhatIsGround);
		for (int i = 0; i < colliders.Length; i++)
		{
			if (colliders[i].gameObject != gameObject && colliders[i].gameObject != this.transform.parent.gameObject)
				return true;
		}

		return false;
	}
}
