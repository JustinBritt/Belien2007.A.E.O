namespace Belien2007.A.E.O.Interfaces.Constraints.QMIP
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.QMIP;

    public interface IConstraints45
    {
        ImmutableList<IConstraints45ConstraintElement> Value { get; }
    }
}