using UnityEngine;
using System.Collections;

public class TimeDilation : MonoBehaviour {

	public float maxDilation;
	public float minDilation;
	public float dilationLength;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.GetComponent<CriticalObject>().isCritical)
		{
			if (dilationLength >= 0.0f)
			{
				dilationLength -= Time.deltaTime;
				if (gameObject.rigidbody2D.gravityScale > 0.0f)
				{
					gameObject.rigidbody2D.gravityScale -= minDilation * Time.deltaTime;
				}
			}
			else
			{
				gameObject.rigidbody2D.gravityScale += maxDilation * Time.deltaTime;
			}
		}
		gameObject.rigidbody2D.velocity *=2.0f;
	}
}
