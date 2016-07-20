using System.Collections.Generic;
using KellermanSoftware.CompareNetObjects;
using NUnit.Framework;

namespace NUnit.DeepObjectCompare.Tests
{
    [TestFixture]
    public class TestIsObjectEqualConstraint
    {
        [Test]
        public void EqualTest()
        {
            var expected = new MyClass() {Foo = "Hello", Bar = 11};
            var actual = new MyClass() {Foo = "Hello", Bar = 11};

            Assert.That(actual, Is.DeepEqualTo(expected));
        }

        [Test]
        public void NotEqualTest()
        {
            var expected = new MyClass() {Foo = "Hello", Bar = 11};
            var actual = new MyClass() {Foo = "Hello", Bar = 12};

            Assert.That(actual, Is.Not.DeepEqualTo(expected));
        }

        [Test]
        public void EqualWithComparisonConfigTest()
        {
            var expected = new MyClass() {Foo = "Hello", Bar = 11};
            var actual = new MyClass() {Foo = "Hello", Bar = 12};

            var comparisonConfig = new ComparisonConfig() { MembersToIgnore = new List<string>() {"Bar"} };

            Assert.That(actual, Is.DeepEqualTo(expected).WithComparisonConfig(comparisonConfig));
        }
    }
}
