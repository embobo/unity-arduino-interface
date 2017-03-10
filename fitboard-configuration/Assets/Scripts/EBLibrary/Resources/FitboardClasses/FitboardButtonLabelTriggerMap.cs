using System.Collections;
using System.Collections.Generic;
using System;

/// <summary>
/// Fitboard button label trigger map.
/// Contains the map to and from button labels used by therapists 
/// and the buttons' trigger values used by Device input
/// </summary>
public static class FitboardButtonLabelTriggerMap
{
	/// <summary>
	/// Tries to get the button trigger value;
	/// </summary>
	/// <returns><c>true</c>, if get button trigger was found, <c>false</c> otherwise.</returns>
	/// <param name="buttonLabel">Button label.</param>
	/// <param name="trigger">Trigger.</param>
	public static bool TryGetButtonTrigger(string buttonLabel, out char trigger) {
		return buttonLabelTriggerDict.TryGetValue (buttonLabel, out trigger);
	}

	/// <summary>
	/// Tries to get the button label.
	/// </summary>
	/// <returns><c>true</c>, if get button label was found, <c>false</c> otherwise.</returns>
	/// <param name="buttonTrigger">Button trigger.</param>
	/// <param name="label">Label.</param>
	public static bool TryGetButtonLabel(char buttonTrigger, out string label) {
		return buttonLabelTriggerDict.TryGetValue (buttonTrigger, out label);
	}

	private static string[] buttonLabels = {
		"Bottom Left 4",
		"Bottom Left 2",
		"Bottom Left 1",
		"Bottom Left 3",
		"Top Left 6", // Top Left as considered from 'Open'
		"Top Left 4",
		"Top Left 2",
		"Top Left 1",
		"Top Left 3",
		"Top Left 5",
		"Top Right 5",
		"Top Right 3",
		"Top Right 1",
		"Top Right 2",
		"Top Right 4",
		"Top Right 6",
		"Bottom Right 3",
		"Bottom Right 1",
		"Bottom Right 2",
		"Bottom Right 4"
	};

	private static char[] buttonTriggers = {
		'A',
		'B',
		'C',
		'D',
		'E',
		'F',
		'G',
		'H',
		'I',
		'J',
		'K',
		'L',
		'M',
		'N',
		'O',
		'P',
		'Q',
		'R',
		'S',
		'T'
	};

	private static OnetoOneBidirectionalDictionary<string,char> buttonLabelTriggerDict 
		= new OnetoOneBidirectionalDictionary<string, char> (buttonLabels, buttonTriggers);
}
