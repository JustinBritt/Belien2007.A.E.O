namespace Belien2007.A.E.O.Interfaces.Calculations.Stochastic.SurgeonStateNumberPatients
{
    using Belien2007.A.E.O.Interfaces.CrossJoins.Stochastic;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Results.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.Interfaces.Results.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Results.Stochastic.SurgeonStateNumberPatients;

    public interface ISurgeonStateNumberPatientsCalculation
    {
        ISurgeonStateNumberPatients Calculate(
            ISurgeonStateNumberPatientsResultElementFactory surgeonStateNumberPatientsResultElementFactory,
            ISurgeonStateNumberPatientsFactory surgeonStateNumberPatientsFactory,
            ISurgeonStateNumberPatientsResultElementCalculation surgeonStateNumberPatientsResultElementCalculation,
            Ii i,
            Isk sk,
            IA A,
            IStochasticn n,
            Ix x);
    }
}