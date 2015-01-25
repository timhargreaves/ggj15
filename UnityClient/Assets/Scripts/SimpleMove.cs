using UnityEngine;
using System.Collections;

public class SimpleMove : MonoBehaviour {

	public Vector3 baseVelocity;
	public float velocityFactor;
	public float delayStart;
	private Vector3 currentVelocity;

	// Use this for initialization
	void Start () {
		currentVelocity = baseVelocity;
		velocityFactor = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (delayStart <= 0.0f)
		{
			currentVelocity = baseVelocity * velocityFactor;
			transform.Translate(currentVelocity * Time.deltaTime);
		}
		else
		{
			delayStart -= Time.deltaTime;
		}
	}

	void OnCollisionEnter2D (Collision2D other)
	{
		baseVelocity = Vector3.zero;
	}
}
