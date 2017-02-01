using UnityEngine;
using System.Collections;

public class PlayerGetState : MonoBehaviour {
    public static bool paralysis = false;
    public static int paralysisTime = 60;
    public static bool invicible = false;
	public static bool HitEnemy = false;
    public static int invicibleTime = 120;
	public static double foodBonus = 0;

	ShotButton shotButton;

	// Use this for initialization
	void Start () {
		shotButton = GameObject.Find("shotButton").GetComponent<ShotButton> ();
		Debug.Log (shotButton.gameObject.name);
	}
	
	// Update is called once per frame
	void Update () {
        if ( paralysis == true ) {
            paralysisTime--;
            if ( paralysisTime == 0 ) {
                paralysis = false;
				Debug.Log ("操作可能");
                paralysisTime = 60;
            }
        }
        if ( invicible == true ) {
            invicibleTime--;
            if ( invicibleTime == 0 ) {
                invicible = false;
                invicibleTime = 120;
            }
        }
	}

	void OnTriggerEnter2D (Collider2D cal) {
        if (cal.tag == "enemy" && invicible == false) {
			HitEnemy = true;
            paralysis = true;
            invicible = true;
			Debug.Log ("硬直確認");
		}
        if (cal.tag == "food") {
			if (shotButton.bullet < shotButton.bulletLimit) {
				shotButton.bullet++;
				shotButton.remainingBullet [shotButton.bullet - 1].SetActive (true);
			}
            Debug.Log("餌取得確認 現残弾数：" + shotButton.bullet.ToString());
			foodBonus += 100;
			Destroy (cal.attachedRigidbody.gameObject);
        }
	}
}
