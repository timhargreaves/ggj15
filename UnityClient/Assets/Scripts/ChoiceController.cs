using UnityEngine;
using System.Collections;

public class ChoiceController : MonoBehaviour {

	public GameObject choice1;
	public GameObject choice2;
	public GameObject correctChoice;
	public Fall criticalObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (criticalObject.isCritical)
		{
			ActivateChoices();

			if (choice1.GetComponent<DisplayChoice>().isTouched)
			{
				if (choice1 == correctChoice)
				{
					choice1.transform.localScale = choice1.transform.localScale * 3;
				}
			}
			if (choice2.GetComponent<DisplayChoice>().isTouched)
			{
				if (choice2 == correctChoice)
				{
					choice2.transform.localScale = choice2.transform.localScale * 3;
				}
			}

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
