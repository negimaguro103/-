using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HitPoint : MonoBehaviour {
	public static int hitPoint = 0;
	[SerializeField]public GameObject[] displayLife = new GameObject[12];
	public static bool damage = false;

	// Use this for initialization
	void Start () {
		for (int i = 11; i >= 0; i--) {
			displayLife [i].SetActive (true);
		}
		hitPoint = 12;
	}
	
	// Update is called once per frame
	void Update () {
		if (damage == true) {
			displayLife [hitPoint - 1].SetActive (false);
			/*switch (hitPoint) {
			case 1:
				Destroy (displayLife[1]);
				break;
			case 2:
				Destroy (displayLife[2]);
				break;
			case 3:
				Destroy (displayLife[3]);
				break;
			case 4:
				Destroy (displayLife[4]);
				break;
			}*/
			hitPoint -= 1;
			damage = false;
		}
	}
}
