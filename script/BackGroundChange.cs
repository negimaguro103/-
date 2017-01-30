using UnityEngine;
using System.Collections;

public class BackGroundChange : MonoBehaviour {
	public GameObject city;
	public GameObject coast;
	public GameObject forest;
	public int chapterNumber = 0;//章番号

	// Use this for initialization
	void Start () {
		switch (chapterNumber) {
		case 0:
			Instantiate (city);
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
