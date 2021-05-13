namespace Belien2007.A.E.O.Interfaces.ResultElements.Common.DayBedOccupancyVariances
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IVarianceResultElement
    {
        IiIndexElement iIndexElement { get; }

        decimal Value { get; }
    }
}