namespace Belien2007.A.E.O.Interfaces.Calculations.Common.DayExpectedBedShortages
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayBedCapacities;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayBedOccupancyMeans;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayBedOccupancyVariances;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayExpectedBedShortages;

    public interface IEBSResultElementCalculation
    {
        IEBSResultElement Calculate(
            IEBSResultElementFactory EBSResultElementFactory,
            IiIndexElement iIndexElement,
            Ic c,
            Iμ μ,
            IVariance Variance);
    }
}