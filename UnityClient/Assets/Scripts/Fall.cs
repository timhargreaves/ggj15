using UnityEngine;
using System.Collections;

public class Fall : MonoBehaviour {

	public Vector3 velocity;
	public float timeToWait;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (timeToWait >= 0.0f)
		{
			timeToWait -= Time.deltaTime;
		}
		else
		{
			Vector3 frameVelocity = velocity * Time.deltaTime;
			transform.Translate(frameVelocity);
		}
	}
}
