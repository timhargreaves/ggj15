using UnityEngine;
using System.Collections;

public class DisplayChoice : MonoBehaviour {

	public float angleMax;
	public float angleMin;
	public float velocity;
	public bool isTouched;
	public GameObject characterBody;

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
		if (characterBody.GetComponent<TimeDilation>().dilationLength <= 0.0f)
		{
			gameObject.SetActive(false);
		}

		float oldY = transform.position.y;
		transform.position = Vector3.MoveTowards(transform.position, endingPosition, velocity * Time.deltaTime);

		float newY = transform.position.y;
		transform.position = new Vector3(transform.position.x, oldY + ((newY - oldY) * 0.35f), 0.0f);

		// Handle touch

		int i = 0;
		while (i < Input.touchCount) {
			if (Input.GetTouch(i).phase == TouchPhase.Began)
			{
				if (gameObject.GetComponent<BoxCollider2D>().bounds.Contains(Input.GetTouch(i).position))
				{
					isTouched = true;
				}
			}
			
			++i;
		}
	}
	
	void OnMouseDown() {
		isTouched = true;
	}
}
