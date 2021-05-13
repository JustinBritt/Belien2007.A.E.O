namespace Belien2007.A.E.O.InterfacesFactories.CrossJoins.Stochastic
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Stochastic;

    public interface IskFactory
    {
        Isk Create(
            ImmutableList<IskCrossJoinElement> value);
    }
}