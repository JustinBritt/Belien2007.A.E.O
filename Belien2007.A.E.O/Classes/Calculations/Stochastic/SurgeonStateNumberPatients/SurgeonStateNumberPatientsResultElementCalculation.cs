namespace Belien2007.A.E.O.Classes.Calculations.Stochastic.SurgeonStateNumberPatients
{
    using System.Linq;

    using log4net;

    using Belien2007.A.E.O.Interfaces.Calculations.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.Interfaces.Results.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Stochastic.SurgeonStateNumberPatients;

    internal sealed class SurgeonStateNumberPatientsResultElementCalculation : ISurgeonStateNumberPatientsResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonStateNumberPatientsResultElementCalculation()
        {
        }

        public ISurgeonStateNumberPatientsResultElement Calculate(
            ISurgeonStateNumberPatientsResultElementFactory surgeonStateNumberPatientsResultElementFactory,
            IkIndexElement kIndexElement,
            IsIndexElement sIndexElement,
            Ii i,
            IA A,
            IStochasticn n,
            Ix x)
        {
            return surgeonStateNumberPatientsResultElementFactory.Create(
                sIndexElement,
                kIndexElement,
                i.Value.Values
                .Where(w => A.GetElementAtAsint(w) == 1)
                .Select(w => 
                x.GetElementAtAsint(
                    w,
                    sIndexElement) 
                * 
                n.GetElementAtAsint(
                    sIndexElement,
                    kIndexElement))
                .Sum());
        }
    }
}