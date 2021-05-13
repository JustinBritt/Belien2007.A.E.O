namespace Belien2007.A.E.O.Classes.ResultElements.Common.SurgeonNumberAssignedDays
{
    using log4net;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.SurgeonNumberAssignedDays;

    internal sealed class SurgeonNumberAssignedDaysResultElement : ISurgeonNumberAssignedDaysResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedDaysResultElement(
            IsIndexElement sIndexElement,
            int value)
        {
            this.sIndexElement = sIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public int Value { get; }
    }
}