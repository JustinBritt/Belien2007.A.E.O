namespace Belien2007.A.E.O.Classes.CrossJoinElements.Common
{
    using log4net;

    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class siCrossJoinElement : IsiCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public siCrossJoinElement(
            IsIndexElement sIndexElement,
            IiIndexElement iIndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.iIndexElement = iIndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IiIndexElement iIndexElement { get; }
    }
}