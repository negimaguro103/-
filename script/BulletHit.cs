using UnityEngine;
using System.Collections;

public class BulletHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D cal) {
		if (cal.tag == "enemy") {
			Destroy (cal.attachedRigidbody.gameObject);
			Destroy (gameObject);
		}
	}
}
