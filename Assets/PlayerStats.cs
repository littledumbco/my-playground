using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerStats : MonoBehaviour {
	
	private string healthStatus;
	private int myHP = 500;
	private int myEXP = 5;

	// Text variables to handle conversion to UI
	public Text uiHP;
	public Text uiEXP;
	public Text uiStatus;

	// Use this for initialization
	void Start () {

	}

	// Script to transform the Stats, HP and EXP into text strings for use in UI
	void StatUpdater () {

		uiStatus.text = "<b>Status:</b> " + healthStatus;
		uiHP.text = "<b>Health:</b> " + myHP.ToString ();
		uiEXP.text = "<b>XP:</b> " + myEXP.ToString ();

	}


	// Update is called once per frame
	void Update () {

		// Ensuring that the HP and XP are always updated into text
		StatUpdater ();

		// User based input to increase or decrease HP
		if (Input.GetKeyDown (KeyCode.Space)) { myHP -= 50; }
		if (Input.GetKeyDown (KeyCode.E)) { myHP += 50; }


		// Updating the health status checker with relevant status
		if ( myHP >= 500 ) { healthStatus = "You're swell"; } 
		else if ( myHP == 250 ) { healthStatus = "You're hurting"; } 
		else if ( myHP <= 0 ) { healthStatus = "You're dead"; }

	}
}
