using UnityEngine;
using System.Collections;

public class FinishMove : MonoBehaviour {

	public Transform targetPosition;
	public float velocity;

	// Use this for initialization
	void Start () {
		velocity = 34.0f * 0.75f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, velocity * Time.deltaTime);
	}
}
