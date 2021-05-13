namespace Belien2007.A.E.O.Classes.Calculations.Stochastic.SurgeonStateNumberPatients
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Belien2007.A.E.O.Interfaces.Calculations.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Stochastic;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Results.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.Interfaces.Results.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Results.Stochastic.SurgeonStateNumberPatients;
    
    internal sealed class SurgeonStateNumberPatientsCalculation : ISurgeonStateNumberPatientsCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonStateNumberPatientsCalculation()
        {
        }

        public ISurgeonStateNumberPatients Calculate(
            ISurgeonStateNumberPatientsResultElementFactory surgeonStateNumberPatientsResultElementFactory,
            ISurgeonStateNumberPatientsFactory surgeonStateNumberPatientsFactory,
            ISurgeonStateNumberPatientsResultElementCalculation surgeonStateNumberPatientsResultElementCalculation,
            Ii i,
            Isk sk,
            IA A,
            IStochasticn n,
            Ix x)
        {
            return surgeonStateNumberPatientsFactory.Create(
                sk.Value
                .Select(w => surgeonStateNumberPatientsResultElementCalculation.Calculate(
                    surgeonStateNumberPatientsResultElementFactory,
                    w.kIndexElement,
                    w.sIndexElement,
                    i,
                    A,
                    n,
                    x))
                .ToImmutableList());
        }
    }
}