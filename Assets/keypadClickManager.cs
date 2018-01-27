using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypadClickManager : MonoBehaviour {
	public Camera cam;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("  clicked keypad .");		
			Ray ray = cam.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				// the object identified by hit.transform was clicked
				// do whatever you want

			}

		
		
		}
	}


}
