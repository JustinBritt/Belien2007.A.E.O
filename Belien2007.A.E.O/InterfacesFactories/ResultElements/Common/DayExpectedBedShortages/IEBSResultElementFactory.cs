namespace Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayExpectedBedShortages
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayExpectedBedShortages;

    public interface IEBSResultElementFactory
    {
        IEBSResultElement Create(
            IiIndexElement iIndexElement,
            decimal value);
    }
}