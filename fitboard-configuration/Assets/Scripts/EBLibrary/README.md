# EBLibrary Requirements

## Unity Settings

### For Serial Port Usage:

Go to *Unity /> Edit /> Project Settings /> Player*

In Inspector set *Optimization /> API Compatibility Level* to '.NET 2.0'

=

### For Arduino Input:

**FitboardDeviceInput.cs must be loaded before all other dependent Monobehavior scripts**

Go to *Edit /> Project Settings /> Script Execution Order*

In Inspector add FitboardDeviceInput.cs

Set time to at least -100 (or lower than lowest dependent script)