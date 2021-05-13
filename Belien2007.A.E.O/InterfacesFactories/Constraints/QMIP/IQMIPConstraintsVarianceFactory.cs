namespace Belien2007.A.E.O.InterfacesFactories.Constraints.QMIP
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.QMIP;
    using Belien2007.A.E.O.Interfaces.Constraints.QMIP;

    public interface IQMIPConstraintsVarianceFactory
    {
        IQMIPConstraintsVariance Create(
            ImmutableList<IQMIPConstraintsVarianceConstraintElement> value);
    }
}