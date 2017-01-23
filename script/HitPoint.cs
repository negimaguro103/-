using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HitPoint : MonoBehaviour {
	public static int hitPoint = 0;
	public GameObject displayLife1;
	public GameObject displayLife2;
	public GameObject displayLife3;
	public GameObject displayLife4;
	public static bool damage = false;

	// Use this for initialization
	void Start () {
		hitPoint = 4;
	}
	
	// Update is called once per frame
	void Update () {
		if (damage == true) {
			switch (hitPoint) {
			case 1:
				Destroy (displayLife4);
				break;
			case 2:
				Destroy (displayLife3);
				break;
			case 3:
				Destroy (displayLife2);
				break;
			case 4:
				Destroy (displayLife1);
				break;
			}
			hitPoint -= 1;
			damage = false;
		}
	}
}
