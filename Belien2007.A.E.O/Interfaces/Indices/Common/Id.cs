namespace Belien2007.A.E.O.Interfaces.Indices.Common
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface Id
    {
        ImmutableList<IdIndexElement> Value { get; }

        IdIndexElement GetElementAt(
            int value);

        IdIndexElement GetElementAt(
            PositiveInt value);

        ImmutableList<IdIndexElement> GetNthElementsAt(
            int startKey,
            int endKey,
            int N);
    }
}