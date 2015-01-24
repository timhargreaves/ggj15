using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChoiceController : MonoBehaviour {

	public GameObject choice1;
	public GameObject choice2;
	public GameObject correctChoice;
	public Fall criticalObject;

	public Text endText;

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
					endText.gameObject.SetActive(true);
				}
			}
			if (choice2.GetComponent<DisplayChoice>().isTouched)
			{
				if (choice2 == correctChoice)
				{
					endText.gameObject.SetActive(true);
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
