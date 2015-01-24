using UnityEngine;
using System.Collections;

public class DisplayChoice : MonoBehaviour {

	public float displayTimeDelay;
	public float angleMax;
	public float angleMin;
	public float velocity;
	public bool isTouched;

	private float randomAngle;
	private Vector3 endingPosition;

	// Use this for initialization
	void Start () {
		gameObject.SetActive(false);
		isTouched = false;

		float random = Random.Range(angleMin, angleMax);

		float randomAngle = random;// - Mathf.PI / 2;

		Quaternion rotation = Quaternion.identity;
		rotation.eulerAngles = new Vector3(0, randomAngle * 180 / Mathf.PI, 0);
		endingPosition = (rotation * Vector3.right) * velocity;
		endingPosition.z = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, endingPosition, velocity * Time.deltaTime);
	}

	void OnMouseDown() {
		isTouched = true;
	}
}
