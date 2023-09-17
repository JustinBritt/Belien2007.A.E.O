namespace Belien2007.A.E.O.Interfaces.Results.Common.DayBedOccupancyMeans
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayBedOccupancyMeans;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface Iμ
    {
        ImmutableList<IμResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IiIndexElement iIndexElement);

        RedBlackTree<FhirDateTime, INullableValue<decimal>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}