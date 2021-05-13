namespace Belien2007.A.E.O.Interfaces.ResultElements.Common.DayDaySurgeonNumberOccupiedBeds
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IUResultElement
    {
        IiIndexElement iIndexElement { get; }

        IjIndexElement jIndexElement { get; }

        IsIndexElement sIndexElement { get; }

        decimal Value { get; }
    }
}