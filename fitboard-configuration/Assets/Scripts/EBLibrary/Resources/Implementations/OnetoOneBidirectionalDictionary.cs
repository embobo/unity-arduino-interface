using System;
using System.Collections;
using System.Collections.Generic;

[System.SerializableAttribute]
public class OnetoOneBidirectionalDictionary <Tkeyval, Ukeyval> 
{
	
	// CONSTRUCTORS:

	public OnetoOneBidirectionalDictionary () {
		if (typeof(Tkeyval) == typeof(Ukeyval))
			throw new InvalidTypeInitializerException("Types must be unique");
		TindexesU = new Dictionary<Tkeyval, Ukeyval> ();
		UindexesT = new Dictionary<Ukeyval, Tkeyval> ();
	}

	public OnetoOneBidirectionalDictionary (Tkeyval[] Tarray, Ukeyval[] Uarray) {
		if (typeof(Tkeyval) == typeof(Ukeyval))
			throw new InvalidTypeInitializerException("Types must be unique");
		TindexesU = new Dictionary<Tkeyval, Ukeyval> ();
		UindexesT = new Dictionary<Ukeyval, Tkeyval> ();

		for (int ii = 0; ii < Math.Min (Tarray.Length,Uarray.Length); ++ii) {
			TryAdd (Tarray [ii], Uarray [ii]);
		}
	}


	// METHODS:

	/// <summary>
	/// Clears this instance.
	/// </summary>
	public void Clear () {
		TindexesU.Clear ();
		UindexesT.Clear ();
	}


	public Dictionary<Tkeyval, Ukeyval>.Enumerator GetEnumerator() {
		return TindexesU.GetEnumerator ();
	}

	/// <summary>
	/// Tries to add the object pair.
	/// </summary>
	/// <returns><c>true</c>, if add wass successful, <c>false</c> otherwise.</returns>
	/// <param name="Tobj">first object.</param>
	/// <param name="Uobj">second object.</param>
	public bool TryAdd (Tkeyval Tobj, Ukeyval Uobj) {
		if (Contains(Tobj) || Contains(Uobj))
			return false;
		Add (Tobj, Uobj);
		return true;
	}


	public override string ToString () {
		return TindexesU.ToString ();
	}

	/// <summary>
	/// Remove the specified object.
	/// </summary>
	/// <returns><c>true</c>, if the object was in the dictionary and could be removed, <c>false</c> otherwise.</returns>
	/// <param name="obj">Object.</param>
	public bool Remove (Tkeyval obj) {
		if (TindexesU.ContainsKey (obj)) {
			Ukeyval val = TindexesU [obj];
			TindexesU.Remove (obj);
			UindexesT.Remove (val);
			return true;
		}
		return false;
	}

	/// <summary>
	/// Remove the specified object.
	/// </summary>
	/// <returns><c>true</c>, if the object was in the dictionary and could be removed, <c>false</c> otherwise.</returns>
	/// <param name="obj">Object.</param>
	public bool Remove (Ukeyval obj) {
		if (UindexesT.ContainsKey (obj)) {
			Tkeyval val = UindexesT [obj];
			UindexesT.Remove (obj);
			TindexesU.Remove (val);
			return true;
		}
		return false;
	}

	/// <summary>
	/// Contains the specified object.
	/// </summary>
	/// <returns><c>true</c>, if the dictionary contains the object, <c>false</c> otherwise.</returns>
	/// <param name="obj">Object.</param>
	public bool Contains (Tkeyval obj) {
		return (TindexesU.ContainsKey (obj) || UindexesT.ContainsValue (obj));
	}

	/// <summary>
	/// Contains the specified object.
	/// </summary>
	/// <returns><c>true</c>, if the dictionary contains the object, <c>false</c> otherwise.</returns>
	/// <param name="obj">Object.</param>
	public bool Contains (Ukeyval obj) {
		return (UindexesT.ContainsKey (obj) || TindexesU.ContainsValue (obj));
	}


	/// <summary>
	/// Tries to get the value corresponding to the key.
	/// </summary>
	/// <returns><c>true</c>, if get key existed in the dictionary, <c>false</c> otherwise.</returns>
	/// <param name="key">Key.</param>
	/// <param name="value">Value.</param>
	public bool TryGetValue (Tkeyval key, out Ukeyval value) {
		return TindexesU.TryGetValue (key, out value);
	}

	/// <summary>
	/// Tries to get the value corresponding to the key.
	/// </summary>
	/// <returns><c>true</c>, if get key existed in the dictionary, <c>false</c> otherwise.</returns>
	/// <param name="key">Key.</param>
	/// <param name="value">Value.</param>
	public bool TryGetValue (Ukeyval key, out Tkeyval value) {
		return UindexesT.TryGetValue (key, out value);
	}


	private void Add (Tkeyval Tobj, Ukeyval Uobj) {
		TindexesU.Add (Tobj, Uobj);
		UindexesT.Add (Uobj, Tobj);
	}


	// PROPERTIES:

	public Tkeyval this [
		Ukeyval key
	] { get { return UindexesT [key]; } 
		set { UindexesT.Add (key, value); } }

	public Ukeyval this [
		Tkeyval key
	] { get { return TindexesU [key]; } 
		set { TindexesU.Add (key, value); } }

	private Dictionary<Tkeyval,Ukeyval> TindexesU;
	private Dictionary<Ukeyval,Tkeyval> UindexesT;

}

//public class TwoWayStringCharDictionary
//{
//	// Constructors
//	public TwoWayStringCharDictionary () {}
//
//
//	// Methods
//
//	public string this [
//		char key
//	] { get { return charToString [key]; } 
//		set { charToString [key] = value; } }
//
//	public char this [
//		string key
//	] { get { return stringToChar [key]; } 
//		set { stringToChar [key] = value; } }
//
//	private Dictionary<string,char> stringToChar;
//	private Dictionary<char,string> charToString;
//
//}