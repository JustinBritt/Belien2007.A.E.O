namespace Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IpParameterElement
    {
        IsIndexElement sIndexElement { get; }

        IdIndexElement dIndexElement { get; }

        FhirDecimal Value { get; }
    }
}