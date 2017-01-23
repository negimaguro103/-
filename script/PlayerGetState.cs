using UnityEngine;
using System.Collections;

public class PlayerGetState : MonoBehaviour {
    public static bool paralysis = false;
    public static int paralysisTime = 120;
    public static bool invicible = false;
    public static int invicibleTime = 300;

	ShotButton shotButton;

	// Use this for initialization
	void Start () {
		shotButton = GetComponent<ShotButton> ();
	}
	
	// Update is called once per frame
	void Update () {
        if ( paralysis == true ) {
            paralysisTime--;
            if ( paralysisTime == 0 ) {
                paralysis = false;
                paralysisTime = 120;
            }
        }
        if ( invicible == true ) {
            invicibleTime--;
            if ( invicibleTime == 0 ) {
                invicible = false;
                invicibleTime = 300;
            }
        }
	}

	void OnTriggerEnter2D (Collider2D cal) {
        if (cal.tag == "enemy" && invicible == false) {
            paralysis = true;
            invicible = true;
			Debug.Log ("硬直確認");
		}
        if (cal.tag == "food") {
			if (shotButton.bullet >= 0 && shotButton.bullet < 6) {
				shotButton.bullet++;
				shotButton.remainingBullet [shotButton.bullet].SetActive (true);
			}
            Debug.Log("餌取得確認 現残弾数：" + shotButton.bullet.ToString());
			Destroy (cal.attachedRigidbody.gameObject);
        }
	}
}
