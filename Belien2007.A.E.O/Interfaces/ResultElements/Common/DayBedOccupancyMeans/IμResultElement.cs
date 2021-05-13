namespace Belien2007.A.E.O.Interfaces.ResultElements.Common.DayBedOccupancyMeans
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IμResultElement
    {
        IiIndexElement iIndexElement { get; }

        decimal Value { get; }
    }
}