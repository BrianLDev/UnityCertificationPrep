using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

	public GameObject projectile;
	public CameraAim aimDirection;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Ray aimRay = aimDirection.GetAimRay();
			Quaternion aimRotation = Quaternion.LookRotation(aimRay.direction);
			Instantiate(projectile, aimRay.origin, aimRotation);
		}
		
	}
}
