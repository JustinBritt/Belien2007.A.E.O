namespace Belien2007.A.E.O.InterfacesFactories.Constraints.SMIP2
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.SMIP2;
    using Belien2007.A.E.O.Interfaces.Constraints.SMIP2;

    public interface ISMIP2ConstraintsVarianceFactory
    {
        ISMIP2ConstraintsVariance Create(
            ImmutableList<ISMIP2ConstraintsVarianceConstraintElement> value);
    }
}