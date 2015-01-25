using UnityEngine;
using System.Collections;

public class CriticalObject : MonoBehaviour {

	public bool isCritical;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == "CriticalTrigger")
		{
			isCritical = true;
		}
	}

	/*
	void OnCollisionEnter2D(Collision2D collision) {
		isCritical = true;
	}
	*/
}
