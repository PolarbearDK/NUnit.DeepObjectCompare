namespace NUnit.DeepObjectCompare
{
    public class Is : NUnit.Framework.Is
    {
        public static DeepObjectEqualConstraint DeepEqualTo(object expected)
        {
            return new DeepObjectEqualConstraint(expected);
        }
    }
}