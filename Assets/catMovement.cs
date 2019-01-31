using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catMovement : MonoBehaviour {
	int x = 0;
	int y = 120;
	//bool left = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (x <= 4*y) {
			//if (!left) {
			//	transform.Rotate (0.0f, 180.0f, 0.0f);
			//	left = true;
			//}
			transform.Translate (-0.05f, 0.0f, 0.0f);
		} else if (x >= 4*y && x <= 8*y) {
			//if (left) {
			//	transform.Rotate (0.0f,180.0f, 0.0f);
			//	left = false;
			//}
			transform.Translate (0.05f, 0.0f, 0.0f);
		} else if (x >= 8*y && x <= 12*y) {
			transform.Translate (0.0f, -0.05f, 0.0f);
		} else if (x >= 12*y && x <= 16*y) {
			transform.Translate (0.0f, 0.05f, 0.0f);
		} else {
			x = 0;
		}
		x += 1;
	}

}
