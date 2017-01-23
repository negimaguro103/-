using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {
	
	private Vector2 pos;
	[SerializeField] private float speed = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		pos = new Vector2 (transform.position.x + speed, transform.position.y);

		transform.position = pos;
	}
}
