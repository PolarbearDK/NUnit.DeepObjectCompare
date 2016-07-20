using KellermanSoftware.CompareNetObjects;
using NUnit.Framework.Constraints;

namespace NUnit.DeepObjectCompare
{
    public class DeepObjectEqualConstraintResult : ConstraintResult
    {
        /// <summary>
        /// Construct an DeepObjectEqualConstraintResult
        /// </summary>
        public DeepObjectEqualConstraintResult(DeepObjectEqualConstraint constraint, object actual, ComparisonResult comparisonResult)
            : base(constraint, actual, comparisonResult.AreEqual)
        {
            _comparisonResult = comparisonResult;
            Constraint = constraint;
        }

        private readonly ComparisonResult _comparisonResult;
        public DeepObjectEqualConstraint Constraint { get; set; }

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