using UnityEngine;
using System.Collections;

public class BulletDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit2D (Collider2D cal)	{
		if (cal.tag == "bullet") {
			Destroy (cal.attachedRigidbody.gameObject);
		}
	}
}
