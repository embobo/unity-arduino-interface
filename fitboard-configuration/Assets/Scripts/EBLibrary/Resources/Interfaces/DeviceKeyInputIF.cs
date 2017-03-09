using System;

public interface DeviceKeyInputIF
{
	/// <summary>
	/// Gets if key was pressed down this frame.
	/// </summary>
	/// <remarks>
	/// Key was not pressed in last frame but is in this frame
	/// </remarks>
	/// <returns><c>true</c>, if key was pressed down this frame, <c>false</c> otherwise.</returns>
	/// <param name="key">Key.</param>
	bool GetKeyDown (char key);

	/// <summary>
	/// Gets if key is pressed this frame.
	/// </summary>
	/// <returns><c>true</c>, if key is pressed in this frame, <c>false</c> otherwise.</returns>
	/// <param name="key">Key.</param>
	bool GetKeyPressed (char key);

	/// <summary>
	/// Gets if the key was released this frame.
	/// </summary>
	/// <returns><c>true</c>, if key was released this frame, <c>false</c> otherwise.</returns>
	/// <param name="key">Key.</param>
	bool GetKeyUp (char key);
}
