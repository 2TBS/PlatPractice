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
		
	}

	public void Load() {
		SceneManager.LoadScene(currLevel);
	}

	public void ChangeLevel(bool increment) {
		try {
			levelText.text = "" + currLevel;
		} catch {
			Debug.Log("LevelText not present");
		}
		currLevel += (increment) ? 1 : -1;
	}

	public void LoadScene() {
		ChangeLevel(true);
		SceneManager.LoadScene(currLevel);
  	}

    public void BackScene() {
         ChangeLevel(false);
		 Load();
     }

    public void GameOver() {
         currLevel = 0;
         Load();
    }
}
