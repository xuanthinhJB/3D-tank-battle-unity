using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

	void onColliderEnter (Collision other) {
		if (other.gameObject.tag == "shell") {
			Destroy(gameObject);
		}
	}
}
