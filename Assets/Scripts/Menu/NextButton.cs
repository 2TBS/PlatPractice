using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour {
    int level = 1;
    bool clicked = true; 
	public void Button_Click()
    {
        if(clicked == true) {

            level++;
            Debug.Log("Displaying level " + level);

        }
        
    }
}
