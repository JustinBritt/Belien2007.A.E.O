namespace Belien2007.A.E.O.Classes.Calculations.Common.DayExpectedBedShortages
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Belien2007.A.E.O.Interfaces.Calculations.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayBedCapacities;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayBedOccupancyMeans;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayBedOccupancyVariances;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DayExpectedBedShortages;

    internal sealed class EBSCalculation : IEBSCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSCalculation()
        {
        }

        public IEBS Calculate(
            IEBSResultElementFactory EBSResultElementFactory,
            IEBSFactory EBSFactory,
            IEBSResultElementCalculation EBSResultElementCalculation,
            Ii i,
            Ic c,
            Iμ μ,
            IVariance Variance)
        {
            return EBSFactory.Create(
                i.Value.Values
                .Select(w => EBSResultElementCalculation.Calculate(
                    EBSResultElementFactory,
                    w,
                    c,
                    μ,
                    Variance))
                .ToImmutableList());
        }
    }
}