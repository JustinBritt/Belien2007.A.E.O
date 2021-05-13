namespace Belien2007.A.E.O.Interfaces.CrossJoins.Stochastic
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Stochastic;

    public interface Isk
    {
        ImmutableList<IskCrossJoinElement> Value { get; }
    }
}