using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

		print("Hello World!");
		print("My name is Brian.\nWelcome to my program.");

		Vector3 currentLocation = new Vector3(1.0f, 4.0f, 3.0f);
		Vector3 home = new Vector3(2.0f, 4.0f, 5.0f);
		Vector3 currLocToHome = currentLocation - home;
		print("Distance to home: " + currLocToHome.magnitude);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
