using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class FitboardReadTest : MonoBehaviour {

	public FitboardDeviceInput fitboardInput;
	public Text[] serialInTextFields;

	private char[] testKeys = {'A','B','E','F','K','L','Q','R'};

	private bool activated;
	private string lastRead;

	// Use this for initialization
	void Start () {
		lastRead = "";
	}
	
	// Update is called once per frame
	void Update () {
		TestKeys ();
		if(fitboardInput && serialInTextFields.Length > 0) {
			try {
				foreach(Text txt in serialInTextFields) {
					lastRead = fitboardInput.ThisFitboardRead;
					if(lastRead != "000000")
						txt.text = txt.text + ",\t" + lastRead;
				}
				
			} catch (System.Exception ex) {
				Debug.Log ("Last read: '" + lastRead + "'\n" + ex.Message);
			}
		}
	}

	private void TestKeys() {
		foreach(char testKey in testKeys) {
			if (fitboardInput.GetKeyDown (testKey))
				Debug.Log(testKey.ToString () + " down this frame");
//			if (fitboardInput.GetKeyPressed (testKey))
//				Debug.Log(testKey.ToString () + " pressed this frame");
			if (fitboardInput.GetKeyUp (testKey))
				Debug.Log(testKey.ToString () + " released this frame");
		}
	}
}
