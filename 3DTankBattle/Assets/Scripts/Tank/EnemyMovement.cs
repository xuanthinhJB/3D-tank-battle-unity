using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
	public int minTime, maxTime;
	private Vector3[] orientation = new Vector3[4];
	bool isTurn = true;

	void direction () {
		Vector3 temPos = transform.position;
		orientation[0] = temPos + Vector3.forward;
		orientation[1] = temPos + Vector3.back;
		orientation[2] = temPos + Vector3.left;
		orientation[3] = temPos + Vector3.right;
	}

	// Use this for initialization
	void Start () {
		direction();
		if (isTurn) 
			StartCoroutine (waitTimeToTurn(Random.Range(minTime, maxTime)));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void turn (int index) {
		transform.LookAt(orientation[index]);
	}

	IEnumerator waitTimeToTurn(int timeDelay) {
		isTurn = false;
		yield return new WaitForSeconds(timeDelay);
		turn(Random.Range(0,4));
		isTurn = true;
	}
}
