using System;

namespace OpenEmma
{
	public interface IOGenericNetwork
	{
		/// <summary>
		/// Open this instance.
		/// </summary>
		void Open ();

		/// <summary>
		/// Close this instance.
		/// </summary>
		void Close ();

		/// <summary>
		/// Read from open connection
		/// </summary>
		string Read ();

		/// <summary>
		/// Write message to connection
		/// </summary>
		/// <param name="msg">Message.</param>
		void Write (string msg);
	}
}

