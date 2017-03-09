using System;
using System.Collections;
using UnityEngine;

/// <summary>
/// Arduino Device Input.
/// This class holds key properties and method implementations that must
/// be used for all Arduino-Unity implementations.
/// </summary>
/// <remarks>
/// This script must be loaded first.
/// To do this:
/// Edit > Project Settings > Script Execution Order
/// + ArduinoManager.cs
/// Set time to at least -100, or lower than lowest dependent script
/// </remarks>
[System.Serializable]
public abstract class ArduinoDeviceInput : MonoBehaviour {


	// ============= Inspector Properties ==============


	[Header ("Serial port connection parameters")]

	[Tooltip("Port name of where the arduino is connected")]
	public string portName = "/dev/tty.usbmodem1411";

	[Tooltip ("Baud rate being used by the arduino")]
	public Baudrates.BaudrateType baudRate = Baudrates.BaudrateType.BPS_9600;

	[Space (10)]

	[Header ("Arduino Connection Events")]
	public BoolEvent onConnectionLost;



	// =================== Methods ====================


	void Awake () {
		DontDestroyOnLoad (this);
		arduino = new ArduinoSerialPort (portName, Baudrates.GetBaudrateToInt (baudRate));
	}
		
	void Start () {
		isConnected = false;
		IsConnected = arduino.TryOpen ();
		ArduinoStartProtocol ();
	}

	protected virtual void ArduinoStartProtocol () { }

	void Update () {
		if(IsConnected) {
			if(!arduino.IsOpen) {
				onConnectionLost.Invoke (true);
				return;
			}
			ArduinoUpdateProtocol ();
		}
	}

	protected virtual void ArduinoUpdateProtocol () { }

	// ============== Scripting Members ===============

	public bool IsConnected {
		get { return isConnected; }
		private set { isConnected = value; }
	}
	private bool isConnected;

	protected ArduinoSerialPort arduino;
}
