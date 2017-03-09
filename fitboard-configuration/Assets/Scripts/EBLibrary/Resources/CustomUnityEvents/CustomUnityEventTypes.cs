using UnityEngine;
using UnityEngine.Events;

public class IntEvent : UnityEvent<int> {}

public class Int2Event : UnityEvent<int,int> {}

[System.Serializable]
public class StringEvent : UnityEvent<string> {}

[System.Serializable]
public class String2Event : UnityEvent<string,string> {}

[System.Serializable]
public class BoolEvent : UnityEvent<bool> {}
