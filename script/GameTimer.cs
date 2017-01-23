using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {
	[SerializeField]private float gameTime = 30;//経過時間
	public static bool TimeUp;
	public static float flameCount = 0;//フレームで数える変数
	[SerializeField]private Text text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameLogic.gameState == GameLogic.GameState.Play) {
			flameCount += 1;
			if (flameCount % 60 == 0) {
				gameTime--;
			}
			if (gameTime == 0) {
				TimeUp = true;
			}
			text.text = "残り時間：" + gameTime.ToString ();
		}
	}
}
