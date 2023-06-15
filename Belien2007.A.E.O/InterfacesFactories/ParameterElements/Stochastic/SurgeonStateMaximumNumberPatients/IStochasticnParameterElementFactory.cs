namespace Belien2007.A.E.O.InterfacesFactories.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients;

    public interface IStochasticnParameterElementFactory
    {
        IStochasticnParameterElement Create(
            IsIndexElement sIndexElement,
            IkIndexElement kIndexElement,
            INullableValue<int> value);
    }
}