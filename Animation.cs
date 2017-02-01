using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour {
	public Animator m_Shot;
	public Animator m_Damge;
	public static bool trigger;

	// Use this for initialization
	void Start () {
		m_Shot = gameObject.GetComponent<Animator> ();
		m_Damge = gameObject.GetComponent<Animator> ();

		
	}
	
	// Update is called once per frame
	void Update () {
		if (ShotButton.trigger == true) {
			m_Shot.SetTrigger ("Shot");
		}
		if (PlayerGetState.HitEnemy == true) {
			m_Damge.SetTrigger ("Damge");
			PlayerGetState.HitEnemy = false;
		}
		
	}
}
