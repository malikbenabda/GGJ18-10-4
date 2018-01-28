using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickManager : MonoBehaviour {
	private Ray ray;
	private Vector3 pos;
	private RaycastHit2D hit;
	// Use this for initialization
	void Start () {
		
	}
	void Update () {
		if ( Input.GetMouseButtonDown(0)){
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			hit = Physics2D.Raycast (ray.origin, ray.direction);
			if (hit ) {
				switch (hit.collider.gameObject.name) {
				case "keypad": Debug.Log ("hit me   ");
				default:					break;
				}


			}		

		}

	}


	void doThekeypadmethod(string s){
		
	}
}
