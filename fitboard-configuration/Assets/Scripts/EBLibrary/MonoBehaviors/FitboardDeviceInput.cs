using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Fitboard manager.
/// This class holds the implentation for ArduinoManager specific
/// to use with the ReGame Fitboard.
/// </summary>
[System.Serializable]
public class FitboardDeviceInput : ArduinoDeviceInput, DeviceKeyInputIF {

	public bool GetKeyDown (char key) {
		if (ThisFitboardRead.Contains (key.ToString ()) && !lastFitboardRead.Contains (key.ToString ()))
			return true;
		return false;
	}

	public bool GetKeyPressed (char key) {
		if (ThisFitboardRead.Contains (key.ToString ()))
			return true;
		return false;
	}

	public bool GetKeyUp (char key) {
		if (!ThisFitboardRead.Contains (key.ToString ()) && lastFitboardRead.Contains (key.ToString ()))
			return true;
		return false;
	}

	protected override void ArduinoStartProtocol () {
		lastFitboardRead = "";
		thisFitboardRead = "";
	}

	protected override void ArduinoUpdateProtocol () {
		ReadFitboardInput ();
	}

	private void ReadFitboardInput () {
		ThisFitboardRead = arduino.ReadLine ().PadRight (expectedChars,'0').Substring(0, expectedChars);
	}

	private string lastFitboardRead;
	public string ThisFitboardRead {
		get { return thisFitboardRead; }
		private set { lastFitboardRead = thisFitboardRead; // should I put lock around this even though access should be serial?
			thisFitboardRead = value; }
	}
	private string thisFitboardRead;

	private const int expectedChars = 6;

}
