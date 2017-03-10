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

### Layout Idea 1

```c#
Interface FitboardConfigurer {

  void AssignButton (string buttonLabel, type assignment); // need to determine the type the assignment will be
  
  void UnassignButton (string buttonLabel);
  
  // a way to retrieve the assignments?
}
```
