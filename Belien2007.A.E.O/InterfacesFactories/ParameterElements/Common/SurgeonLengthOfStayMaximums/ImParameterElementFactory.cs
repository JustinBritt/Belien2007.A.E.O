namespace Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonLengthOfStayMaximums
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonLengthOfStayMaximums;

    public interface ImParameterElementFactory
    {
        ImParameterElement Create(
            IsIndexElement sIndexElement,
            INullableValue<int> value);
    }
}