namespace Belien2007.A.E.O.Interfaces.Calculations.Stochastic.SurgeonStateNumberPatients
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.Interfaces.Results.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Stochastic.SurgeonStateNumberPatients;

    public interface ISurgeonStateNumberPatientsResultElementCalculation
    {
        ISurgeonStateNumberPatientsResultElement Calculate(
            ISurgeonStateNumberPatientsResultElementFactory surgeonStateNumberPatientsResultElementFactory,
            IkIndexElement kIndexElement,
            IsIndexElement sIndexElement,
            Ii i,
            IA A,
            IStochasticn n,
            Ix x);
    }
}