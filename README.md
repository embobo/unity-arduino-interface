# Unity Arduino Test README

This repo is for tracking my attempts to create an interface with Arduino for Unity.

## Serial Connection Interface

### Public methods needed:

* `void OpenConnection();`

* `void CloseConnection();`

* `string ReadLine();`

* `void Write(string msg);`
