namespace Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;

    public interface IStochasticnParameterElement
    {
        IsIndexElement sIndexElement { get; }

        IkIndexElement kIndexElement { get; }

        PositiveInt Value { get; }
    }
}