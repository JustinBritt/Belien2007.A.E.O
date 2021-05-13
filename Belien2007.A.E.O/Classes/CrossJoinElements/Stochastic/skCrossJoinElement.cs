namespace Belien2007.A.E.O.Classes.CrossJoinElements.Stochastic
{
    using log4net;

    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;

    internal sealed class skCrossJoinElement : IskCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public skCrossJoinElement(
            IsIndexElement sIndexElement,
            IkIndexElement kIndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.kIndexElement = kIndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IkIndexElement kIndexElement { get; }
    }
}