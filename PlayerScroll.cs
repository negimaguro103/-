using UnityEngine;
using System.Collections;

public class PlayerScroll : MonoBehaviour {
	private Vector3 touchStartPos;
	private Vector3 touchEndPos;
	[SerializeField]string Direction;
	PlayerControl playerControl;

	void Flick(){
		if(Input.GetKeyDown(KeyCode.Mouse0)){
			touchStartPos = new Vector3(Input.mousePosition.x,
										Input.mousePosition.y,
										Input.mousePosition.z);
		}
		if (Input.GetKeyUp (KeyCode.Mouse0)) {
			touchEndPos = new Vector3 (Input.mousePosition.x,
										Input.mousePosition.y,
										Input.mousePosition.z);
			GetDirection ();
		}
	}

	void GetDirection(){
		float directionX = touchEndPos.x - touchStartPos.x;
		float directionY = touchEndPos.y - touchStartPos.y;

		if (Mathf.Abs (directionY) < Mathf.Abs (directionX)) {
			if (30 < directionX) {
				Direction = "right";
			} else if (-30 > directionX) {
				Direction = "left";
			}
		}else if (Mathf.Abs(directionX)<Mathf.Abs(directionY)){
			if (30 < directionY){
				Direction = "up";
			}else if ( -30 > directionY){
				Direction = "down";
			}
		}else{
			Direction = "none";
		}
	}

	
	void Start () {
		playerControl = GetComponent<PlayerControl>();
	}
	
	// Update is called once per frame
	void Update () {

		Flick ();
        if ( GameLogic.gameState == GameLogic.GameState.Play && PlayerGetState.paralysis == false ) {
            switch ( Direction ) {
                case "up":
                    playerControl.MoveToUp( );
                    break;
            
                case "down":
                    playerControl.MoveToDown( );
                    break;

                case "right":
                    break;

                case "left":
                    break;

                case "none":
                    break;
            }
        }
		Direction = "none";
	}
}
