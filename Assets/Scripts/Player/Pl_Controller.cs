using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pl_Controller : MonoBehaviour {
	public Rigidbody2D PlayerRG;
	public Camera mainCamera;
	public LayerMask layerM;
	public int speed;
	public int jumpForce;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Horizontal Movement
		float value = Input.GetAxis ("Horizontal"); 
		PlayerRG.velocity = new Vector2(value*speed,PlayerRG.velocity.y);
		//Jump movement
		if(Input.GetButtonDown("Jump")){
			//Raycast
			RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1.0f);
			Debug.Log(hit);


			if (hit != null && hit.collider.tag == "ground") {
				Debug.Log(hit);
				PlayerRG.AddForce (Vector2.up * jumpForce, ForceMode2D.Impulse);
				Debug.DrawLine (transform.position, hit.point, Color.cyan);
			}
			Debug.DrawRay(transform.position, transform.TransformDirection (Vector3.down) *1000, Color.white);

			Debug.Log("jump key");			
		}
	}

	void Update() {
		mainCamera.transform.position = new Vector3(transform.position.x, transform.position.y, mainCamera.transform.position.z);
	}
}
