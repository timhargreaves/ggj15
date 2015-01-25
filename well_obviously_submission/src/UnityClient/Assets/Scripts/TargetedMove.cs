using UnityEngine;
using System.Collections;

public class TargetedMove : MonoBehaviour {

	public Transform primaryTarget;
	public Transform secondaryTarget;
	public bool correctAction;

	public Vector3 currentTarget;
	public float velocity;

	// Use this for initialization
	void Start () {
		velocity = 34.0f;
		currentTarget = primaryTarget.position;
	}
	
	// Update is called once per frame
	void Update () {
		//if (transform.position == primaryTarget.position)
		{

		}
		transform.position = Vector3.MoveTowards(transform.position, currentTarget, velocity * Time.deltaTime);

	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.name == "CharacterBody")
		{
			 
			gameObject.GetComponent<DisplayEndGameState>().DisplayState(correctAction);
			currentTarget = secondaryTarget.position;
			velocity = 34.0f * 0.75f;}
	}
}
