using UnityEngine;
using System.Collections;

public class Fall : MonoBehaviour {

	public bool isCritical;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	/*
	void OnTriggerEnter2D(Collider2D other) {
		isCritical = true;
	}
*/
	void OnCollisionEnter2D(Collision2D collision) {
		isCritical = true;
	}
}
