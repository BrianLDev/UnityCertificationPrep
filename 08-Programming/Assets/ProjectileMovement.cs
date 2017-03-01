using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour {
	// public Vector3 newPosition;
	private float forceMin = 1.0f;
	private float forceMax = 25.0f;
	
	private bool hasLaunched = false;


	// Use this for initialization
	void Start () {
		//UpdatePosition();
		
	}

	// public void UpdatePosition() {
	// 	Transform trans = GetComponent<Transform>();
	// 	trans.position = newPosition;
	// }
	
	// Update is called once per frame
	void FixedUpdate () {
		// Vector3 positionDelta = new Vector3(0, 0, speed * Time.deltaTime);
		// transform.position = transform.position + positionDelta;
		Rigidbody rb = GetComponent<Rigidbody>();
		if(!hasLaunched ) {
			float force = Random.Range(forceMin, forceMax);
			print(force);
			rb.AddForce(transform.forward * force, ForceMode.Impulse);
			hasLaunched = true;
		}

	}
}
