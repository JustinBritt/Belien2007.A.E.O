namespace Belien2007.A.E.O.InterfacesFactories.Results.Common.DayDaySurgeonNumberOccupiedBeds
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayDaySurgeonNumberOccupiedBeds;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayDaySurgeonNumberOccupiedBeds;

    public interface IUFactory
    {
        IU Create(
            ImmutableList<IUResultElement> value);
    }
}