namespace NUnit.DeepObjectCompare
{
    /// <summary>
    /// Helper class with properties and methods that supply
    /// a number of constraints used in Asserts.
    /// </summary>
    public class Is : NUnit.Framework.Is
    {
        /// <summary>
        /// Returns a constraint that tests two objects for deep object equality
        /// </summary>
        public static DeepObjectEqualConstraint DeepEqualTo(object expected)
        {
            return new DeepObjectEqualConstraint(expected);
        }
    }
}