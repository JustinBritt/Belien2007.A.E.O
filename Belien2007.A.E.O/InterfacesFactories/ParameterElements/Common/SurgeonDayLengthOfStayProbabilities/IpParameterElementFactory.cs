namespace Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities;

    public interface IpParameterElementFactory
    {
        IpParameterElement Create(
            IsIndexElement sIndexElement,
            IdIndexElement dIndexElement,
            FhirDecimal value);
    }
}