using UnityEngine;
using System.Collections;

public class DisplayChoice : MonoBehaviour {

	public float displayTimeDelay;
	public Vector3 endingPosition;
	public float velocity;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, endingPosition, velocity * Time.deltaTime);
	}
}
