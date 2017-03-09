using System;
using System.Text;
using System.IO.Ports;

/// <summary>
/// Arduino serial port.
/// Serial Port that defaults with properties used for arduino connections
/// </summary>
public class ArduinoSerialPort : SerialPort
{
	public ArduinoSerialPort (string portName, int baudrate) {
		PortName = portName;
		BaudRate = baudrate;
		Encoding = new UTF8Encoding (true, true);
		DtrEnable = true;
	}

	/// <summary>
	/// Tries to open the connection.
	/// </summary>
	/// <returns><c>true</c>, if connection successfully opened, <c>false</c> otherwise.</returns>
	public bool TryOpen () {
		try {
			Open ();
		} catch {
			return false;
		}
		return true;
	}


	private ArduinoSerialPort () { }
}
