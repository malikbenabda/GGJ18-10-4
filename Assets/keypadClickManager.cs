using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypadClickManager : MonoBehaviour {
	
	private Ray ray;
	private Vector3 pos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetMouseButtonDown(0)){
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction);
			if (hit ) {
				switch (hit.collider.gameObject.name) {
				case "keypad":					doThekeypadmethod ("keypad dhrabet");
				default:
					break;
				}


			}		
				
		}

	}


	void doThekeypadmethod(string s){
		Debug.Log ("hit me   " + s);
	}
}
