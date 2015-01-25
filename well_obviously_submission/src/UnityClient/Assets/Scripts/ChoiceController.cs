using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChoiceController : MonoBehaviour {

	public GameObject[] choices;
	public GameObject correctChoice;
	public CriticalObject criticalObject;

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
}
