using System;

[System.Serializable]
public class InvalidTypeInitializerException : System.Exception
{
	public InvalidTypeInitializerException () : base() { }
	public InvalidTypeInitializerException (string message) : base(message) { }
	public InvalidTypeInitializerException (string message, System.Exception inner) : base(message, inner) { }

	protected InvalidTypeInitializerException (System.Runtime.Serialization.SerializationInfo info,
		System.Runtime.Serialization.StreamingContext context) { }
}
