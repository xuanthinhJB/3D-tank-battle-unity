using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooting : MonoBehaviour {
	public Rigidbody shellRigid;
	public Transform firePoint;
	public float rangeFire = 90;

	public void Fire() {
		Rigidbody shell = Instantiate (shellRigid, firePoint.position, firePoint.rotation) as Rigidbody;
		shell.velocity = rangeFire * firePoint.forward;	
	}
}
