namespace Belien2007.A.E.O.Interfaces.Constraints.SMIP2
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.SMIP2;

    public interface IConstraintsμ
    {
        ImmutableList<IConstraintsμConstraintElement> Value { get; }
    }
}