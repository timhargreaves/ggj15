using UnityEngine;
using System.Collections;

public class ChoiceController : MonoBehaviour {

	public GameObject choice1;
	public GameObject choice2;
	public MonoBehaviour criticalObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (((Fall)criticalObject).isCritical)
		{
			ActivateChoices();
		}
	}

	public void ActivateChoices()
	{
		if (choice1.activeSelf)
		{
			choice1.SetActive(true);
		}
	}
}
