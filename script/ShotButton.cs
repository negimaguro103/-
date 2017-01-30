using UnityEngine;
using System.Collections;

public class ShotButton : MonoBehaviour {
	public static bool trigger;
    public int bullet = 4;
	public int bulletLimit = 9;
	[SerializeField]public GameObject[] remainingBullet = new GameObject[9];
	// Use this for initialization
	void Start () {
		remainingBullet [0].SetActive (true);
		remainingBullet [1].SetActive (true);
		remainingBullet [2].SetActive (true);
		remainingBullet [3].SetActive (true);
		remainingBullet [4].SetActive (false);
		remainingBullet [5].SetActive (false);
		remainingBullet [6].SetActive (false);
		remainingBullet [7].SetActive (false);
		remainingBullet [8].SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnMouseDown() {
		if (bullet > 0 && GameLogic.gameState == GameLogic.GameState.Play && PlayerGetState.paralysis == false) {
			if (bullet >= 0 && bullet <= bulletLimit) {
				remainingBullet[bullet - 1].SetActive (false);
				bullet -= 1;
			}
			trigger = true;
            Debug.Log("現残弾数：" + bullet.ToString());
		}
	}
}
