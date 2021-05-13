namespace Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateProbabilities
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;

    public interface IhParameterElement
    {
        IsIndexElement sIndexElement { get; }

        IkIndexElement kIndexElement { get; }

        FhirDecimal Value { get; }
    }
}