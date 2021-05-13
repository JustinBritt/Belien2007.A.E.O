namespace Belien2007.A.E.O.Interfaces.Results.Common.Gap
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IGap
    {
        decimal Value { get; }

        INullableValue<decimal> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}