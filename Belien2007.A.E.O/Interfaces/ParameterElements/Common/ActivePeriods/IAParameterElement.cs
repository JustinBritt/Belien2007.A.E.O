namespace Belien2007.A.E.O.Interfaces.ParameterElements.Common.ActivePeriods
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IAParameterElement
    {
        IiIndexElement iIndexElement { get; }

        FhirBoolean Value { get; }
    }
}