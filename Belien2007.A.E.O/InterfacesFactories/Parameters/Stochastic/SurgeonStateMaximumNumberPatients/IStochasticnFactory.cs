namespace Belien2007.A.E.O.InterfacesFactories.Parameters.Stochastic.SurgeonStateMaximumNumberPatients
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateMaximumNumberPatients;

    public interface IStochasticnFactory
    {
        IStochasticn Create(
            ImmutableList<IStochasticnParameterElement> value);
    }
}