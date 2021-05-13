namespace Belien2007.A.E.O.Classes.Calculations.Stochastic.StateNumberPatients
{
    using System.Linq;

    using Belien2007.A.E.O.Interfaces.Calculations.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.Interfaces.Results.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Stochastic.StateNumberPatients;

    internal sealed class StateNumberPatientsResultElementCalculation : IStateNumberPatientsResultElementCalculation
    {
        public StateNumberPatientsResultElementCalculation()
        {
        }

        public IStateNumberPatientsResultElement Calculate(
            IStateNumberPatientsResultElementFactory stateNumberPatientsResultElementFactory,
            IkIndexElement kIndexElement,
            ISurgeonStateNumberPatients surgeonStateNumberPatients)
        {
            return stateNumberPatientsResultElementFactory.Create(
                kIndexElement,
                surgeonStateNumberPatients.Value
                .Where(w => w.kIndexElement == kIndexElement)
                .Select(w => w.Value)
                .Sum());
        }
    }
}