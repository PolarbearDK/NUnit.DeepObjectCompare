NUnit.DeepObjectCompare
=======================

Add deep object comparison to NUnit.

##Example:

```csharp
using NUnit.DeepObjectCompare;
or
using Is = NUnit.DeepObjectCompare.Is;

Assert.That(actualObject, Is.DeepEqualTo(expectedObject));
```

