namespace Belien2007.A.E.O.Interfaces.ResultElements.Common.DayExpectedBedShortages
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IEBSResultElement
    {
        IiIndexElement iIndexElement { get; }

        decimal Value { get; }
    }
}