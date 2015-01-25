using UnityEngine;
using System.Collections;

public class BungeeCustomStartMove : MonoBehaviour {

	private Vector3 topOfJumpPosition;
	private float velocity;

	// Use this for initialization
	void Start () {
		topOfJumpPosition = transform.position + new Vector3(0.0f, 0.6f);
		velocity = 0.2f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, topOfJumpPosition, Time.deltaTime * velocity);
		if (transform.position.y >= topOfJumpPosition.y)
		{
			gameObject.GetComponent<SimpleMove>().enabled = true;
			this.enabled = false;
		}

	}
}
