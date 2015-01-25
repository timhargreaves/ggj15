using UnityEngine;
using System.Collections;

public class TimeDilation : MonoBehaviour {

	public float maxDilation;
	public float minDilation;
	public float dilationLength;
	public float dilationRate;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.GetComponent<CriticalObject>().isCritical)
		{
			if (dilationLength > 0.0f)
			{
				if (gameObject.GetComponent<SimpleMove>().velocityFactor > minDilation)
				{
					gameObject.GetComponent<SimpleMove>().velocityFactor -= dilationRate * Time.deltaTime;
				}
				dilationLength -= Time.deltaTime;

			}
			else
			{
				if (gameObject.GetComponent<SimpleMove>().velocityFactor < maxDilation)
				{
					gameObject.GetComponent<SimpleMove>().velocityFactor += dilationRate * 2.0f * Time.deltaTime;
				}
			}
		}
	}
}
