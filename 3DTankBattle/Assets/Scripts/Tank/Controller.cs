using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	private PlayerMovement playerScript;
	private TankShooting playerFireScript;

	// Use this for initialization
	void Start () {
		GameObject playObj = GameObject.FindGameObjectWithTag ("Player");
		playerScript = (PlayerMovement)playObj.GetComponent (typeof(PlayerMovement));
		playerFireScript = (TankShooting)playObj.GetComponent (typeof(TankShooting));
	}
	
	public void goUp() {
		playerScript.isTop = true;
	}

	public void goDown() {
		playerScript.isBottom = true;
	}

	public void turnLeft() {
		playerScript.isLeft = true;
	}

	public void turnRight() {
		playerScript.isRight = true;
	}

	public void releaseMovement() {
		playerScript.isTop = false;
		playerScript.isBottom = false;
		playerScript.isLeft = false;
		playerScript.isRight = false;
	}

	public void tankFire() {
		playerFireScript.Fire (); 
	}
}
