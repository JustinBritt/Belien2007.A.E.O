namespace Belien2007.A.E.O.InterfacesFactories.Results.Common.DayBedOccupancyVariances
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayBedOccupancyVariances;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayBedOccupancyVariances;

    public interface IVarianceFactory
    {
        IVariance Create(
            ImmutableList<IVarianceResultElement> value);
    }
}