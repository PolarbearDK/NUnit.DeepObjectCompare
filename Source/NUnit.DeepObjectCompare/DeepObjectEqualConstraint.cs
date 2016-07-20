using KellermanSoftware.CompareNetObjects;
using NUnit.Framework.Constraints;

namespace NUnit.DeepObjectCompare
{
    public class DeepObjectEqualConstraint : Constraint
    {
        public DeepObjectEqualConstraint(params object[] args)
            : base(args)
        {
        }

        private CompareLogic _compareLogic = new CompareLogic(new ComparisonConfig());
        private ComparisonResult _comparisonResult;

        public override string Description
        {
            get
            {
                if (_comparisonResult == null) return null;
                return _comparisonResult.AreEqual ? $"<{Arguments[0]}>" : _comparisonResult.DifferencesString;
            }
        }

        public DeepObjectEqualConstraint WithComparisonConfig(ComparisonConfig comparisonConfig)
        {
            _compareLogic = new CompareLogic(comparisonConfig);
            return this;
        }

        public DeepObjectEqualConstraint WithCompareLogic(CompareLogic compareLogic)
        {
            _compareLogic = compareLogic;
            return this;
        }

        public override ConstraintResult ApplyTo<TActual>(TActual actual)
        {
            _comparisonResult = _compareLogic.Compare(Arguments[0], actual);
            return new DeepObjectEqualConstraintResult(this, actual, _comparisonResult);
        }
    }
}