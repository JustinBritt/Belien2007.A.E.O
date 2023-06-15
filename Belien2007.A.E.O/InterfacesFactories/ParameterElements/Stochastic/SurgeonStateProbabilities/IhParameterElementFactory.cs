namespace Belien2007.A.E.O.InterfacesFactories.ParameterElements.Stochastic.SurgeonStateProbabilities
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateProbabilities;

    public interface IhParameterElementFactory
    {
        IhParameterElement Create(
            IsIndexElement sIndexElement,
            IkIndexElement kIndexElement,
            INullableValue<decimal> value);
    }
}