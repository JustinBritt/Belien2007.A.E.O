namespace Belien2007.A.E.O.Interfaces.Constraints.QMIP
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.QMIP;

    public interface IQMIPConstraintsVariance
    {
        ImmutableList<IQMIPConstraintsVarianceConstraintElement> Value { get; }
    }
}