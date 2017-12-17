using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pl_Controller : MonoBehaviour {
	public Rigidbody PlayerRG;
	public Camera mainCamera;
	public LayerMask layerM;
	public int speed;
	public int jumpForce;
	public double velocity;

	///Speed multiplier - larger value = faster
    public float moveSpeed = .5f;

	///Acceleration due to gravity
	public float gravity = 9.8f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Horizontal Movement
		float value = Input.GetAxis ("Horizontal"); 
		//Jump movement
		if(Input.GetButtonDown("Jump")){
			//Raycast
			RaycastHit hit;

			if (Physics.Linecast(transform.position, Vector3.down, out hit) && hit.collider.tag == "ground") {
				Debug.Log(hit);
				PlayerRG.AddForce (Vector3.up * jumpForce, ForceMode.Impulse);
				Debug.DrawLine (transform.position, hit.point, Color.cyan);
			}
			Debug.DrawRay(transform.position, transform.TransformDirection (Vector3.down) *1000, Color.white);

			Debug.Log("jump key");			
		}
	}

	void Update() {
		mainCamera.transform.position = new Vector3(transform.position.x, transform.position.y, mainCamera.transform.position.z);

		if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * moveSpeed);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * moveSpeed);

		transform.Translate(Vector3.down * velocity * Time.deltaTime);
	}
}
