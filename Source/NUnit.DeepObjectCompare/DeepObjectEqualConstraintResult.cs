using KellermanSoftware.CompareNetObjects;
using NUnit.Framework.Constraints;

namespace NUnit.DeepObjectCompare
{
    /// <summary>
    /// Result from deep object comparison
    /// </summary>
    public class DeepObjectEqualConstraintResult : ConstraintResult
    {
        private readonly DeepObjectEqualConstraint _constraint;
        private readonly ComparisonResult _comparisonResult;

        /// <summary>
        /// Construct an DeepObjectEqualConstraintResult
        /// </summary>
        public DeepObjectEqualConstraintResult(DeepObjectEqualConstraint constraint, object actual, ComparisonResult comparisonResult)
            : base(constraint, actual, comparisonResult.AreEqual)
        {
            _constraint = constraint;
            _comparisonResult = comparisonResult;
        }

        /// <summary>
        /// Write a failure message. Overridden to list deep object differences
        /// </summary>
        /// <param name="writer">The MessageWriter on which to display the message</param>
        public override void WriteMessageTo(MessageWriter writer)
        {
            writer.WriteLine(_comparisonResult.DifferencesString);
        }
    }
}