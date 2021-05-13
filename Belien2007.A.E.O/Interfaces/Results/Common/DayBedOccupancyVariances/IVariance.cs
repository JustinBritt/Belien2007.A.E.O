namespace Belien2007.A.E.O.Interfaces.Results.Common.DayBedOccupancyVariances
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayBedOccupancyVariances;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IVariance
    {
        ImmutableList<IVarianceResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IiIndexElement iIndexElement);

        ImmutableList<Tuple<FhirDateTime, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}