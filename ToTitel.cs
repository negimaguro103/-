using UnityEngine;
using System.Collections;

public class ToTitel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnMouseDown() {
		GameTimer.TimeUp = false;
		Application.LoadLevel ("Novel2");
	}
}
