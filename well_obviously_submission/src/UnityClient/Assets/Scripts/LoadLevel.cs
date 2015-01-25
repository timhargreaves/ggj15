using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public string nextLevel;
	// Use this for initialization
	void Start () {
		if (string.IsNullOrEmpty(nextLevel))
		{
			nextLevel = "bungee";
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ClickButton(string buttonID){
		Application.LoadLevel(nextLevel);
	}
}
