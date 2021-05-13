namespace Belien2007.A.E.O.Interfaces.Constraints.SMIP2
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.SMIP2;

    public interface ISMIP2ConstraintsVariance
    {
        ImmutableList<ISMIP2ConstraintsVarianceConstraintElement> Value { get; }
    }
}