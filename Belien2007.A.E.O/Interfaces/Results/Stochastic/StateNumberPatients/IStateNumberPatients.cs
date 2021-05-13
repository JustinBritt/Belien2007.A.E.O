namespace Belien2007.A.E.O.Interfaces.Results.Stochastic.StateNumberPatients
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IStateNumberPatients
    {
        ImmutableList<IStateNumberPatientsResultElement> Value { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}