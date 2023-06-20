namespace Belien2007.A.E.O.Classes.Calculations.Stochastic.StateNumberPatients
{
    using System.Collections.Immutable;
    using System.Linq;

    using Belien2007.A.E.O.Interfaces.Calculations.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.Interfaces.Indices.Stochastic;
    using Belien2007.A.E.O.Interfaces.Results.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.Interfaces.Results.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Results.Stochastic.StateNumberPatients;

    internal sealed class StateNumberPatientsCalculation : IStateNumberPatientsCalculation
    {
        public StateNumberPatientsCalculation()
        {
        }

        public IStateNumberPatients Calculate(
            IStateNumberPatientsResultElementFactory stateNumberPatientsResultElementFactory,
            IStateNumberPatientsFactory stateNumberPatientsFactory,
            IStateNumberPatientsResultElementCalculation stateNumberPatientsResultElementCalculation,
            Ik k,
            ISurgeonStateNumberPatients surgeonStateNumberPatients)
        {
            return stateNumberPatientsFactory.Create(
                k.Value.Values
                .Select(w => stateNumberPatientsResultElementCalculation.Calculate(
                    stateNumberPatientsResultElementFactory,
                    w,
                    surgeonStateNumberPatients))
                .ToImmutableList());
        }
    }
}