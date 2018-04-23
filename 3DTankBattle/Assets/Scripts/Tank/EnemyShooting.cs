using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : TankShooting {
	private bool isFire = true;

	void Update () {
		if (isFire) {
			StartCoroutine(fireDelay());
		}
	}

	IEnumerator fireDelay() {
		isFire = false;
		yield return new WaitForSeconds (Random.Range(0.5f, 1.5f));
		isFire = true;
		Fire ();
	}
}
