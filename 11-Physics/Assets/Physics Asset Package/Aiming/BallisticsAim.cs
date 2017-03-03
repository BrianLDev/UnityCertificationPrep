using UnityEngine;
using System.Collections;

public class BallisticsAim : MonoBehaviour {

    public BallisticSolver solver;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var ray = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity, 1 << 8));     // for the 8th layer, need to enter 1 shifted by 8 bits (i.e. 1 << 8)
        {
            print(hitInfo.point);
            solver.target = hitInfo.point;
        }
    }
}
