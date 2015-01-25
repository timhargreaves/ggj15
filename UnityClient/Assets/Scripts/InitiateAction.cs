using UnityEngine;
using System.Collections;

public class InitiateAction : MonoBehaviour {

	public GameObject action;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!action.activeSelf && gameObject.GetComponent<DisplayChoice>().isTouched)
		{
			action.SetActive(true);
		}
	}
}
