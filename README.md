# NUnit.DeepObjectCompare

Add deep object comparison to NUnit.

## Usage
Available as a NuGet package: [NUnit.DeepObjectCompare](https://www.nuget.org/packages/NUnit.DeepObjectCompare/)

To install NUnit.DeepObjectCompare, run the following command in the Package Manager Console
```Powershell
PM> Install-Package NUnit.DeepObjectCompare
```

Add using statement

```csharp
using NUnit.DeepObjectCompare;
or
using Is = NUnit.DeepObjectCompare.Is;
```

Assert deep equality:
```csharp
Assert.That(actualObject, Is.DeepEqualTo(expectedObject));
```

Assert deep Inequality:
```csharp
Assert.That(actualObject, Is.Not.DeepEqualTo(expectedObject));
```

## Additional examples
For more examples, check out the unit tests for this project:
[Miracle.Settings](https://github.com/PolarbearDK/Miracle.Settings)