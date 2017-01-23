using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	[SerializeField]private float speedY;
	const int MinLane = -1;
	const int MaxLane = 1;
	const float LaneWidth = 2.0f;
	public GameObject shot;

	CharacterController controller;
	int targetLane;
	Vector3 moveDirection = Vector3.zero;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (ShotButton.trigger == true) {
			Shot ();
		}
		float ratioY = (targetLane * LaneWidth - transform.position.y) / LaneWidth;
        moveDirection.y = ratioY * speedY;

		Vector3 globalDirection = transform.TransformDirection (moveDirection);
		controller.Move (globalDirection * Time.deltaTime);
	}

	public void MoveToUp () 
	{
		if (targetLane < MaxLane)
			targetLane++;
	}

	public void MoveToDown ()
	{
		if (targetLane > MinLane)
			targetLane--;
	}

	public void Shot() {
		GameObject obj = (GameObject)GameObject.Instantiate (shot);

		obj.transform.parent = transform;
		obj.transform.localPosition = new Vector3 (0, 1.1f, 0);
		ShotButton.trigger = false;
	}

}
