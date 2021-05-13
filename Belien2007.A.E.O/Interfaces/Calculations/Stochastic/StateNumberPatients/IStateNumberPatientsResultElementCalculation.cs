namespace Belien2007.A.E.O.Interfaces.Calculations.Stochastic.StateNumberPatients
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.Interfaces.Results.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Stochastic.StateNumberPatients;

    public interface IStateNumberPatientsResultElementCalculation
    {
        IStateNumberPatientsResultElement Calculate(
            IStateNumberPatientsResultElementFactory stateNumberPatientsResultElementFactory,
            IkIndexElement kIndexElement,
            ISurgeonStateNumberPatients surgeonStateNumberPatients);
    }
}