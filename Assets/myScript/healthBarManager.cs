using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBarManager : MonoBehaviour {

	public bool gridMode = false; //if this is true, the health is many grids

	[SerializeField] private GameObject oneHealthImage;
	private int currentHealth = 0;
	private UnityEngine.UI.GridLayoutGroup myHealthLayout;
	// Use this for initialization

	void Awake() {
		currentHealth = 0; //init the health to 0, then, in start, add right init health amount 
		myHealthLayout = gameObject.GetComponent<UnityEngine.UI.GridLayoutGroup> (); 
	}

	// this do after awake, so, the palyer set up the health in the Awake;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate () {
	}

	public int setHealth(int health){
		currentHealth = health;

		if (health >= 0) {
			myHealthLayout.cellSize = new Vector2 (health, myHealthLayout.cellSize.y);
		}

		return currentHealth;
	}

	public int getUIcurrentHealth(){
		return currentHealth;
	}
}

/*
 * 
 public class healthBarManager : MonoBehaviour {

	public bool gridMode = false; //if this is true, the health is many grids

	[SerializeField] private GameObject oneHealthImage;
	private int currentHealth = 0;

	// Use this for initialization

	void Awake() {
		currentHealth = 0; //init the health to 0, then, in start, add right init health amount
		foreach (Transform child in gameObject.transform) {
			GameObject.Destroy(child.gameObject);
		}
	}

	// this do after awake, so, the palyer set up the health in the Awake;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate () {
		Debug.Log (gameObject.transform.childCount);
	}

	public int setHealth(int health){



if (health <= 0) {
	foreach (Transform child in gameObject.transform) {
		GameObject.Destroy (child.gameObject);
	}
	currentHealth = health;
} else if (currentHealth > health) {
	int a = 0;
	while (gameObject.transform.childCount > health) {
		GameObject.Destroy (gameObject.transform.GetChild (0).gameObject);
		Debug.Log (a++);
		//break;
	}
	currentHealth = health;
} else {
	while (gameObject.transform.childCount < health) {
		Instantiate (oneHealthImage, gameObject.transform);
	}
	currentHealth = health;
}　

if (currentHealth == 0) {
	for (int i = 0; i < health; ++i) {
		Instantiate (oneHealthImage, gameObject.transform);
	}
}

foreach (Transform child in gameObject.transform) {
	if (gameObject.transform.childCount <= health) {
		return 1;
	}
	//GameObject.Destroy(child.gameObject);
	child.parent = null;
}



return currentHealth;
}

public int getUIcurrentHealth(){
	return currentHealth;
}
}
 */
