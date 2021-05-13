namespace Belien2007.A.E.O.Interfaces.Results.Common.DayDaySurgeonNumberOccupiedBeds
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayDaySurgeonNumberOccupiedBeds;

    public interface IU
    {
        ImmutableList<IUResultElement> Value { get; }
    }
}