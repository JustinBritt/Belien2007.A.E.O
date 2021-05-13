namespace Belien2007.A.E.O.Classes.ResultElements.Common.DaySurgeonNumberBlockAssignments
{
    using log4net;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DaySurgeonNumberBlockAssignments;

    internal sealed class xResultElement : IxResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xResultElement(
            IiIndexElement iIndexElement,
            IsIndexElement sIndexElement,
            int value)
        {
            this.iIndexElement = iIndexElement;

            this.sIndexElement = sIndexElement;

            this.Value = value;
        }

        public IiIndexElement iIndexElement { get; }

        public IsIndexElement sIndexElement { get; }

        public int Value { get; }
    }
}