namespace Belien2007.A.E.O.Interfaces.Calculations.Common.DayExpectedBedShortages
{
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayBedCapacities;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayBedOccupancyMeans;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayBedOccupancyVariances;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DayExpectedBedShortages;

    public interface IEBSCalculation
    {
        IEBS Calculate(
            IEBSResultElementFactory EBSResultElementFactory,
            IEBSFactory EBSFactory,
            IEBSResultElementCalculation EBSResultElementCalculation,
            Ii i,
            Ic c,
            Iμ μ,
            IVariance Variance);
    }
}