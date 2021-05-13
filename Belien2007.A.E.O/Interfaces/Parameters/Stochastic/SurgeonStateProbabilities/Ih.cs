namespace Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateProbabilities
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateProbabilities;

    public interface Ih
    {
        ImmutableList<IhParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement,
            IkIndexElement kIndexElement);
    }
}