namespace Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonMaximumNumberPatients
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface ICommonnParameterElement
    {
        IsIndexElement sIndexElement { get; }

        INullableValue<int> Value { get; }
    }
}