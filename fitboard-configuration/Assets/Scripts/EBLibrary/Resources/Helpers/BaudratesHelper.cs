public static class Baudrates {

	public enum BaudrateType {
		BPS_300,
		BPS_600,
		BPS_1200,
		BPS_2400,
		BPS_4800,
		BPS_9600,
		BPS_14400,
		BPS_19200,
		BPS_28800,
		BPS_38400,
		BPS_57600,
		BPS_115200,
		BPS_UNKNOWN
	}

	/// <summary>
	/// Gets baudrate to int.
	/// </summary>
	/// <returns>The baudrate as int.</returns>
	/// <param name="rate">BaudrateType Rate.</param>
	public static int GetBaudrateToInt(BaudrateType rate) {
		switch (rate) {
		case BaudrateType.BPS_9600:
			return 9600;
		case BaudrateType.BPS_300:
			return 300;
		case BaudrateType.BPS_600:
			return 600;
		case BaudrateType.BPS_1200:
			return 1200;
		case BaudrateType.BPS_2400:
			return 2400;
		case BaudrateType.BPS_4800:
			return 4800;
		case BaudrateType.BPS_14400:
			return 14400;
		case BaudrateType.BPS_19200:
			return 19200;
		case BaudrateType.BPS_28800:
			return 28800;
		case BaudrateType.BPS_38400:
			return 38400;
		case BaudrateType.BPS_57600:
			return 57600;
		case BaudrateType.BPS_115200:
			return 115200;
		default:
			return -1;
		}
	}

	public static double GetSecondsPerChar(int baudrate) {
		return (1 / baudrate) * 8; // reads char as int which is 8 bits
	}

	public static double GetBytesPerSecond(BaudrateType rate) {
		int baudrate = GetBaudrateToInt (rate);
		return GetSecondsPerChar (baudrate);
	}
}