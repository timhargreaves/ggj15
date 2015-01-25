using UnityEngine;
using System.Collections;

public class TargetedMove : MonoBehaviour {

	public Transform target;
	public bool correctAction;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, this.target.position, 34.0f * Time.deltaTime);
		if (transform.position == this.target.position)
		{
			gameObject.GetComponent<DisplayEndGameState>().DisplayState(correctAction);
		}
	}
}
