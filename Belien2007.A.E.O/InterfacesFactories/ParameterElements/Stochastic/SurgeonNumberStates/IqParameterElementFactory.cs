namespace Belien2007.A.E.O.InterfacesFactories.ParameterElements.Stochastic.SurgeonNumberStates
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonNumberStates;

    public interface IqParameterElementFactory
    {
        IqParameterElement Create(
            IsIndexElement sIndexElement,
            PositiveInt value);
    }
}