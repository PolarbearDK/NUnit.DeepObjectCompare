using NUnit.Framework.Constraints;

namespace NUnit.DeepObjectCompare
{
    /// <summary>
    /// Add ability to do DeepEqualTo on ConstraintExpressions
    /// </summary>
    public static class ConstraintExpressionExtensions
    {
        /// <summary>
        /// Returns a constraint that tests two objects for deep object equality
        /// </summary>
        public static DeepObjectEqualConstraint DeepEqualTo(this ConstraintExpression constraint, object expected)
        {
            return (DeepObjectEqualConstraint)constraint.Append(new DeepObjectEqualConstraint(expected));
        }
    }
}