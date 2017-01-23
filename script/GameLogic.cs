using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {

	public GameObject enemy;

	public enum GameState
	{
		GameBegin,
		Play,
		Pause,
		GameCleared,
		Gameover,
		Empty
	}

	public static GameState gameState;

	// Use this for initialization
	void Start () {
		gameState = GameState.GameBegin;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.V)) {
			gameState = GameState.Pause;
			Debug.Log ("ポーズ中");
		}

		if (Input.GetKeyDown (KeyCode.C)) {
			gameState = GameState.Play;
			Debug.Log ("再起");
		}

		if (gameState == GameState.Play) {
			enemy.SetActive (true);
		} else {
			enemy.SetActive (false);
		}

		if (GameTimer.TimeUp == true) {
			gameState = GameState.GameCleared;
			Debug.Log ("クリア");
		}
		if (HitPoint.hitPoint <= 0) {
			gameState = GameState.Gameover;
			Debug.Log ("ゲームオーバー");
		}
	}
}
