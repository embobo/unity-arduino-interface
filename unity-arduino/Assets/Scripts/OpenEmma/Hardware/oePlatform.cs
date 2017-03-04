using System;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;

namespace OpenEmma
{
	public static class oePlatform
	{
		/// <summary>
		/// Gets the running platform
		/// </summary>
		/// <value>The TARGE t PLATFOR.</value>
		public static PlatformOS RUNNING_PLATFORM {
			get { return running_platform; }
			private set { running_platform = value; }
		}
		private static PlatformOS running_platform = RunningPlatform ();

		public enum PlatformOS
		{
			MAC,
			WINDOWS,
			LINUX,
			UNKNOWN
		}

		private static PlatformOS RunningPlatform ()
		{
			switch (Environment.OSVersion.Platform)
			{
			case PlatformID.Unix:
				if (Directory.Exists("/Applications")
					& Directory.Exists("/System")
					& Directory.Exists("/Users")
					& Directory.Exists("/Volumes"))
					return PlatformOS.MAC;
				else
					return PlatformOS.LINUX;
			case PlatformID.MacOSX:
				return PlatformOS.MAC;
			case PlatformID.Win32Windows:
				return PlatformOS.WINDOWS;
			case PlatformID.Win32NT:
				return PlatformOS.WINDOWS;
			case PlatformID.Win32S:
				return PlatformOS.WINDOWS;
			case PlatformID.WinCE:
				return PlatformOS.WINDOWS;
			default:
				return PlatformOS.UNKNOWN;
			}
		}
	}

}

