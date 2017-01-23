using UnityEngine;
using System.Collections;

public class ShotButton : MonoBehaviour {
	public static bool trigger;
    public int bullet = 4;
	[SerializeField]public GameObject[] remainingBullet = new GameObject[6];
	// Use this for initialization
	void Start () {
		remainingBullet [4].SetActive (false);
		remainingBullet [5].SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnMouseDown() {
        if (bullet > 0 && GameLogic.gameState == GameLogic.GameState.Play) {
			if (bullet >= 0 && bullet < 6) {
				remainingBullet[bullet].SetActive (false);
				bullet -= 1;
			}
			trigger = true;
            Debug.Log("現残弾数：" + bullet.ToString());
		}
	}
}
