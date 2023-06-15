namespace Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonLengthOfStayMaximums
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface ImParameterElement
    {
        IsIndexElement sIndexElement { get; }

        INullableValue<int> Value { get; }
    }
}