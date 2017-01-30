using UnityEngine;
using System.Collections;

public class BulletHit : MonoBehaviour {
	public static double damageBonus = 0;
	public int bonusFlag;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D cal) {
		if (cal.tag == "enemy") {
			if (gameObject.transform.position.x >= 5) {
				bonusFlag = 0;
			}
			if (gameObject.transform.position.x < 5 && gameObject.transform.position.x >= 0) {
				bonusFlag = 1;
			}
			if (gameObject.transform.position.x < 0) {
				bonusFlag = 2;
			}
			switch (bonusFlag) {
			case 0:
				damageBonus += 10 * 1.5;
				break;
			case 1:
				damageBonus += 10 * 1.3;
				break;
			case 2:
				damageBonus += 10 * 1.1;
				break;
			}
			Debug.Log ("ダメージボーナス："+ damageBonus);
			Destroy (cal.attachedRigidbody.gameObject);
			Destroy (gameObject);
		}
	}
}
