namespace Belien2007.A.E.O.Interfaces.Constraints.MIP2
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.MIP2;

    public interface IConstraints320
    {
        ImmutableList<IConstraints320ConstraintElement> Value { get; }
    }
}