using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pl_Controller : MonoBehaviour {
	public Rigidbody2D PlayerRG;

	public int speed = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//simple Horizontal movement
		 float value = Input.GetAxis ("Horizontal"); 
		 PlayerRG.AddForce(new Vector2(value,0)*speed);
	}
}
