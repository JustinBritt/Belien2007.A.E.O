namespace Belien2007.A.E.O.Interfaces.Results.Common.DaySurgeonNumberBlockAssignments
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface Ix
    {
        ImmutableList<IxResultElement> Value { get; }

        int GetElementAtAsint(
            IiIndexElement iIndexElement,
            IsIndexElement sIndexElement);

        ImmutableList<Tuple<FhirDateTime, Organization, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Ii i,
            Is s);
    }
}