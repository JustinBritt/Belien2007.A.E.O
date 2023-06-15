namespace Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonMaximumNumberPatients
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonMaximumNumberPatients;

    public interface ICommonnParameterElementFactory
    {
        ICommonnParameterElement Create(
            IsIndexElement sIndexElement,
            INullableValue<int> value);
    }
}