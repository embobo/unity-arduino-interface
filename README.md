# Unity Arduino Test README

This repo is for tracking my attempts to create an interface with Arduino for Unity.

## Network Interface

* `void Open ();` - open the connection, throw exception if failed

* `void Close ();` - close the connection

* `string Read ();` - read line from the connection

* `void Write (string msg);` - write to the connection

## Device Key Input Interface

* `bool GetKeyDown (char key);` - return true if the key was pressed during this frame, otherwise false

* `bool GetKeyPressed (char key);` - return true if the key is currently pressed, otherwise false

* `bool GetKeyUp (char key);` - return true if the key was released during this frame, otherwise false
