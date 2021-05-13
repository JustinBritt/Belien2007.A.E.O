namespace Belien2007.A.E.O.InterfacesFactories.Parameters.Stochastic.SurgeonStateProbabilities
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateProbabilities;

    public interface IhFactory
    {
        Ih Create(
            ImmutableList<IhParameterElement> value);
    }
}