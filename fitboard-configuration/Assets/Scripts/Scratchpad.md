# Scratchpad

Scratchpad for mapping out fitboard user/software configuration

### Fitboard buttons notes

A fitboard button consists of a software facing `char trigger` and a user facing `string label`.

**Trigger**

* `char` unique to each fitboard button (except the top panels where front/back reuse characters)
* sent from Arduino program over serial connection when button is pressed

**Label**

* name used by physical therapist and clients to identify fitboard buttons
* used in configuration screen

=

### Button-GameObject Assignment Ideas

#### ~~Assign Objects to Buttons~~

```c#
Interface FitboardConfigurer {

  void AssignButton (string buttonLabel, type assignment); // need to determine the type the assignment will be
  
  void UnassignButton (string buttonLabel);
  
  // a way to retrieve the assignments?
}
```
>
No no no no no no no. The buttons shouldn't care what they're assigned to- that doesn't make sense. The objects assigned to a button care what their button(s) can be.
>

#### Assign Buttons to Objects with buttonlabel

```c#
Interface GameObjectConfigurer {

  void AssignButtonToObject (string objName, string buttonLabel);
  
  void UnassignButtonToObject (string objName, string buttonLabel);
  
}
```

##### Reasoning

I think this is better for now because the buttonLabel can be used to retrieve the button trigger from a fitboard class. This removes the need for the UI to know what the button's trigger is and the button trigger can be in a Unity independent class.

**OR**

#### Assign Buttons to Objects with buttonTrigger

```c#
Interface GameObjectConfigurer {

  void AssignButtonToObject (string objName, char buttonTrigger);
  
  void UnassignButtonToObject (string objName, char buttonTrigger);
  
}
```
