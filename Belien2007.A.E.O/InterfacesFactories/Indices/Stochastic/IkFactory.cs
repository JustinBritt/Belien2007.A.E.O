namespace Belien2007.A.E.O.InterfacesFactories.Indices.Stochastic
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.Comparers;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.Indices.Stochastic;

    public interface IkFactory
    {
        Ik Create(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IkIndexElement> value);
    }
}