using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerStats : MonoBehaviour {
	
	public Text healthStatus;
	private int myHP = 500;
	private int myEXP = 5;
	public Text uiHP;
	public Text uiEXP;

	// Use this for initialization
	void Start () {

		healthStatus.text = "Super Alive!";


	}

	// Script to transform the HP and EXP into text strings
	void StatUpdater () {

		uiHP.text = "Health: " + myHP.ToString ();
		uiEXP.text = "XP: " + myEXP.ToString ();

	}


	// Update is called once per frame
	void Update () {

		// Ensuring that the HP and XP are always updated into text
		StatUpdater ();

		// User based input to increase or decrease HP
		if (Input.GetKeyDown (KeyCode.Space)) { myHP -= 50; }
		if (Input.GetKeyDown (KeyCode.E)) { myHP += 50; }


		// Updating the health status checker with relevant status
		if ( myHP >= 500 ) { healthStatus.text = "You're swell"; } 
		else if ( myHP == 250 ) { healthStatus.text = "You're hurting"; } 
		else if ( myHP <= 0 ) { healthStatus.text = "You're dead"; }

	}
}
