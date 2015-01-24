using UnityEngine;
using System.Collections;

public class Fall : MonoBehaviour {

	public Vector3 velocity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 frameVelocity = velocity * Time.deltaTime;
		transform.Translate(frameVelocity);
	}
}
