using UnityEngine;
using System.Collections;

public class DisplayChoice : MonoBehaviour {

	public float displayTimeDelay;
	public Vector3 endingPosition;
	public float velocity;
	public bool isTouched;

	// Use this for initialization
	void Start () {
		gameObject.SetActive(false);
		isTouched = false;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, endingPosition, velocity * Time.deltaTime);
	}

	void OnMouseDown() {
		isTouched = true;
	}
}
