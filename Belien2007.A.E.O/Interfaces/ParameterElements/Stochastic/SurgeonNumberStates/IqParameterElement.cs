namespace Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonNumberStates
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IqParameterElement
    {
        IsIndexElement sIndexElement { get; }

        INullableValue<int> Value { get; }
    }
}