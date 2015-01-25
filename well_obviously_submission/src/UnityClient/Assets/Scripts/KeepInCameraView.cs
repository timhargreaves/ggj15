using UnityEngine;
using System.Collections;

public class KeepInCameraView : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = Camera.main.WorldToViewportPoint (transform.position);
		pos.x = Mathf.Clamp(pos.x, 0.1f, 0.9f);
		pos.y = Mathf.Clamp(pos.y, 0.1f, 0.8f);
		transform.position = Camera.main.ViewportToWorldPoint(pos);
	}
}
