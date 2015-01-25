using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayEndGameState : MonoBehaviour {

	public Text endTextBox;
	public string endText;
	public Button contextButton;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DisplayState(bool isSuccess) {
		endTextBox.text = endText;
		endTextBox.gameObject.SetActive(true);
		contextButton.gameObject.SetActive(true);
		/*
		if (isSuccess)
		{
			criticalObject.GetComponent<SimpleMove>().baseVelocity = Vector3.zero;
		}
		*/
	}
}
