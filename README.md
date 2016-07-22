# NUnit.DeepObjectCompare

Add deep (per property) object comparison to NUnit.


## Usage
Available as a NuGet package: [NUnit.DeepObjectCompare](https://www.nuget.org/packages/NUnit.DeepObjectCompare/)

To install NUnit.DeepObjectCompare, run the following command in the Package Manager Console
```Powershell
PM> Install-Package NUnit.DeepObjectCompare
```

### Add using statement

```csharp
using NUnit.DeepObjectCompare;
or
using Is = NUnit.DeepObjectCompare.Is;
```

### Assert deep equality:
```csharp
Assert.That(actualObject, Is.DeepEqualTo(expectedObject));
```

### Assert deep inequality:
```csharp
Assert.That(actualObject, Is.Not.DeepEqualTo(expectedObject));
```

### Assert equality (advanced):

```csharp
var comparisonConfig = new ComparisonConfig() { MembersToIgnore = new List<string>() {"Bar"} };

Assert.That(actualObject, Is.DeepEqualTo(expectedObject).WithComparisonConfig(comparisonConfig));
```
Use WithComparisonConfig or WithCompareLogic to configure the specifics of the comparison.
See [CompareNetObjects](https://www.nuget.org/packages/CompareNETObjects) which is the excelent comparison engine used by NUnit.DeepObjectCompare

## Additional examples
For more examples, check out the unit tests for these projects:
* [Miracle.Settings](https://github.com/PolarbearDK/Miracle.Settings)