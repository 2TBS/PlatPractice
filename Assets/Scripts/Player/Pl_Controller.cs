using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pl_Controller : MonoBehaviour {
	public Rigidbody2D PlayerRG;

	public int speed;
	public int jumpForce;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float value = Input.GetAxis ("Horizontal"); 
		PlayerRG.velocity = new Vector2(value*speed,PlayerRG.velocity.y);
		if(Input.GetButtonDown("Jump")){
			PlayerRG.AddForce (Vector2.up * jumpForce, ForceMode2D.Impulse);
		}
	}
}
