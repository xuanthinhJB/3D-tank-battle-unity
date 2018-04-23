using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour {
	public float m_Speed = 7f;
	public float m_pitchRange = 0.2f;

	protected Rigidbody mRigidBody;

	private void Awake() {
		mRigidBody = GetComponent<Rigidbody> ();
	}

	private void OnEnabled() {
		if (mRigidBody != null) {
			mRigidBody.isKinematic = false;
		}
	}

	private void OnDesabled() {
		if (mRigidBody != null) {
			mRigidBody.isKinematic = true;
		}
	}

	//protected moving() {
		
}
