namespace Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayBedOccupancyMeans
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayBedOccupancyMeans;

    public interface IμResultElementFactory
    {
        IμResultElement Create(
            IiIndexElement iIndexElement,
            decimal value);
    }
}