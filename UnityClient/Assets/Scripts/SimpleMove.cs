using UnityEngine;
using System.Collections;

public class SimpleMove : MonoBehaviour {

	public Vector3 velocity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(velocity * Time.deltaTime);
	}

	void OnCollisionEnter2D (Collision2D other)
	{
		velocity = Vector3.zero;
	}
}
