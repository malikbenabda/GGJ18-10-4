using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour {
	public float speed = 3f;
	Vector2 sceanR =new Vector2 (13, 0); 
	Vector2 sceanL =new Vector2 (-13, 0); 
	Vector2 sceanM =new Vector2 (0, 0); 
	Vector2 sceanU =new Vector2 (0, 10); 
	// Use this for initialization
	void Start () {

	}


	void Update() {
		float step = speed * Time.deltaTime;
		transform.position = Vector2.MoveTowards( transform.position,sceanR, step);

	}

	// Update is called once per frame
	void FixedUpdate  () {
	/*	if (Input.GetKeyDown (KeyCode.RightArrow)) {

		transform.position = new Vector3 (transform.position.x + 13 *Time.deltaTime, transform.transform.position.y);
		}
	*/	
	}
}
