using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour {
	[SerializeField]private Text nomalScore;
	[SerializeField]private Text damageBonusScore;
	[SerializeField]private Text foodBonus;
	[SerializeField]private Text totalScore;
	private double clearBonus = 0;
	private double total = 0;

	// Use this for initialization
	void Start () {
		if (GameLogic.clearFlag == true) {
			clearBonus = 3000;
		}
		if (GameLogic.clearFlag == false) {
			clearBonus = -5000;
		}
		total = BulletHit.damageBonus + PlayerGetState.foodBonus + clearBonus;
	}
	
	// Update is called once per frame
	void Update () {
		nomalScore.text = "基本ボーナス\n3000";
		damageBonusScore.text = "ダメージボーナス\n" + BulletHit.damageBonus.ToString();
		foodBonus.text = "エサボーナス\n" + PlayerGetState.foodBonus.ToString ();
		totalScore.text = "合計ボーナス\n" + total.ToString ();
	}
}
