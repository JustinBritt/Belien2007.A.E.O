namespace Belien2007.A.E.O.Interfaces.Indices.Stochastic
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;

    public interface Ik
    {
        ImmutableList<IkIndexElement> Value { get; }

        IkIndexElement GetElementAt(
            int value);

        IkIndexElement GetElementAt(
            PositiveInt value);
    }
}