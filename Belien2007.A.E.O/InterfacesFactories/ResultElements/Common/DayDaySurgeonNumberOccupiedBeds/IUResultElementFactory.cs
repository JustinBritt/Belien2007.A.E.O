namespace Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayDaySurgeonNumberOccupiedBeds
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayDaySurgeonNumberOccupiedBeds;

    public interface IUResultElementFactory
    {
        IUResultElement Create(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IsIndexElement sIndexElement,
            decimal value);
    }
}