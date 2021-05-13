namespace Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayBedOccupancyVariances
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayBedOccupancyVariances;

    public interface IVarianceResultElementFactory
    {
        IVarianceResultElement Create(
            IiIndexElement iIndexElement,
            decimal value);
    }
}