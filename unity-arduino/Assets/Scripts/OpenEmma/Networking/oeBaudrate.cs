using System;

namespace OpenEmma
{
	public static class oeBaudrate {

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
		/// Converts baudrate to int.
		/// </summary>
		/// <returns>The baudrate as int.</returns>
		/// <param name="rate">BaudrateType Rate.</param>
		public static int ToInt(BaudrateType rate) {
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

		/// <summary>
		/// Gets the seconds per byte.
		/// </summary>
		/// <returns>The seconds per byte.</returns>
		/// <param name="rate">Rate.</param>
		public static double GetSecondsPerByte (int rate) {
			return (1 / rate) * 8;
		}

		/// <summary>
		/// Gets the milli seconds per byte.
		/// </summary>
		/// <returns>The milli seconds per byte.</returns>
		/// <param name="rate">Rate.</param>
		public static float GetMilliSecondsPerByte (int rate) {
			return (8000 / rate);
		}
	}

}

