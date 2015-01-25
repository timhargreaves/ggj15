using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChoiceController : MonoBehaviour {

	public GameObject[] choices;
	public GameObject correctChoice;
	public CriticalObject criticalObject;

	public Text endText;
	public Button nextButton;

	private bool choicesActivated;

	// Use this for initialization
	void Start () {
		choicesActivated = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (criticalObject.isCritical)
		{
			if (!choicesActivated)
			{
				ActivateChoices();
				choicesActivated = true;
			}

			CheckForTouches();
		}
	}

	public void ActivateChoices()
	{
		foreach (GameObject choice in choices)
		{
			if (!choice.activeSelf)
			{
				choice.SetActive(true);
			}
		}
	}

	void CheckForTouches ()
	{
		foreach (GameObject choice in choices)
		{
			if (choice == correctChoice)
			{
				if (choice.GetComponent<DisplayChoice>().isTouched)
				{
					endText.text = "A winner is you!";
					endText.gameObject.SetActive(true);
					nextButton.gameObject.SetActive(true);
				}
			}
			else
			{
				if (choice.GetComponent<DisplayChoice>().isTouched)
				{
					endText.text = "You done goofed";
					endText.gameObject.SetActive(true);
				}
			}
		}
	}
}
