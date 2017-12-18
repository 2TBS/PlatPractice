using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MM_Menu : MonoBehaviour {


	public int currLevel = 1;
	public Text levelText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		levelText.text = "" + currLevel;
	}

	public void Load() {
		SceneManager.LoadScene(currLevel);
	}

	public void ChangeLevel(bool increment) {
		currLevel += (increment) ? 1 : -1;
	}
}
