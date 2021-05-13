namespace Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateMaximumNumberPatients
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients;

    public interface IStochasticn
    {
        ImmutableList<IStochasticnParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IkIndexElement kIndexElement);
    }
}