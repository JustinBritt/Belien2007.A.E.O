namespace Belien2007.A.E.O.InterfacesFactories.Constraints.QMIP
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.QMIP;
    using Belien2007.A.E.O.Interfaces.Constraints.QMIP;

    public interface IConstraints45Factory
    {
        IConstraints45 Create(
            ImmutableList<IConstraints45ConstraintElement> value);
    }
}