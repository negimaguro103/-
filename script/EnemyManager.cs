using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour {

	public GameObject enemy1Object;
	public GameObject foodObject;

	private int laneNumber;
	private float y;
	private int enemyNumber;

	[SerializeField]private float nextSpawnTime = 0;
	[SerializeField]private float interval = 1;

	public float instantiateTime = 0;//生成時間

	// Use this for initialization
	void Start () {
		enemyNumber = Random.Range (0, 2);
		laneNumber = Random.Range (0, 3);
	}
	
	// Update is called once per frame
	void Update () {
		if (GameLogic.gameState == GameLogic.GameState.Play) {
			if (nextSpawnTime < GameTimer.flameCount){
				LocalInstantate ();
				nextSpawnTime = GameTimer.flameCount + 60;
			}
		}
	}
	void LocalInstantate () {

		switch (laneNumber) {
		case 0:
			y = 3.0f;
			break;
		case 1:
			y = 1.1f;
			break;
		case 2: 
			y = -0.8f;
			break;
		}

		switch (enemyNumber) {
		case 0:
			GameObject obj1 = (GameObject)GameObject.Instantiate (enemy1Object);

			obj1.transform.parent = transform;

			obj1.transform.localPosition = new Vector3 (13, y, 0);
			break;
		case 1:
			GameObject obj2 = (GameObject)GameObject.Instantiate (foodObject);

			obj2.transform.parent = transform;

			obj2.transform.localPosition = new Vector3 (13, y, 0);
			break;
		}
		enemyNumber = Random.Range (0, 2);
		laneNumber = Random.Range (0, 3);
	}
}
