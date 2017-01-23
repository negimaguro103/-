using UnityEngine;
using System.Collections;

public class ObjectDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerExit2D (Collider2D cal)	{
		Destroy (cal.attachedRigidbody.gameObject);
	}

	void OnTriggerEnter2D (Collider2D cal) {
        if (cal.tag == "enemy") {
			HitPoint.damage = true;
			Debug.Log ("hit");
		}
	}
}