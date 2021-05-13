namespace Belien2007.A.E.O.Classes.ResultElements.Common.DayDaySurgeonNumberOccupiedBeds
{
    using log4net;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayDaySurgeonNumberOccupiedBeds;

    internal sealed class UResultElement : IUResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UResultElement(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IsIndexElement sIndexElement,
            decimal value)
        {
            this.iIndexElement = iIndexElement;

            this.jIndexElement = jIndexElement;

            this.sIndexElement = sIndexElement;

            this.Value = value;
        }

        public IiIndexElement iIndexElement { get; }

        public IjIndexElement jIndexElement { get; }

        public IsIndexElement sIndexElement { get; }

        public decimal Value { get; }
    }
}