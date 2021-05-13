namespace Belien2007.A.E.O.Interfaces.Calculations.Stochastic.StateNumberPatients
{
    using Belien2007.A.E.O.Interfaces.Indices.Stochastic;
    using Belien2007.A.E.O.Interfaces.Results.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.Interfaces.Results.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Results.Stochastic.StateNumberPatients;

    public interface IStateNumberPatientsCalculation
    {
        IStateNumberPatients Calculate(
            IStateNumberPatientsResultElementFactory stateNumberPatientsResultElementFactory,
            IStateNumberPatientsFactory stateNumberPatientsFactory,
            IStateNumberPatientsResultElementCalculation stateNumberPatientsResultElementCalculation,
            Ik k,
            ISurgeonStateNumberPatients surgeonStateNumberPatients);
    }
}