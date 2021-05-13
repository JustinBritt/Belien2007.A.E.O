namespace Belien2007.A.E.O.Classes.ResultElements.Common.DayBedOccupancyMeans
{
    using log4net;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayBedOccupancyMeans;

    internal sealed class μResultElement : IμResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public μResultElement(
            IiIndexElement iIndexElement,
            decimal value)
        {
            this.iIndexElement = iIndexElement;

            this.Value = value;
        }

        public IiIndexElement iIndexElement { get; }

        public decimal Value { get; }
    }
}