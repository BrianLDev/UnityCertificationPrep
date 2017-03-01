using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAim : MonoBehaviour {

	public Ray GetAimRay() {
		Camera ourCamera;
		ourCamera = GetComponent<Camera>();
		Ray aimRay = ourCamera.ScreenPointToRay(Input.mousePosition);
		return aimRay;
		//Debug.DrawRay(aimRay.origin, aimRay.direction, Color.red, 5);
	}
}
