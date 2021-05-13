namespace Belien2007.A.E.O.Classes.ResultElements.Common.DayExpectedBedShortages
{
    using log4net;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayExpectedBedShortages;

    internal sealed class EBSResultElement : IEBSResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSResultElement(
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