using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector2.left * .25f);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector2.right * .25f);
    }
}
