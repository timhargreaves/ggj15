using UnityEngine;
using System.Collections;

public class ChoiceController : MonoBehaviour {

	public GameObject choice1;
	public GameObject choice2;
	public Fall criticalObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (criticalObject.isCritical)
		{
			ActivateChoices();
		}
	}

	public void ActivateChoices()
	{
		if (!choice1.activeSelf)
		{
			choice1.SetActive(true);
		}
		if (!choice2.activeSelf)
		{
			choice2.SetActive(true);
		}
	}
}
