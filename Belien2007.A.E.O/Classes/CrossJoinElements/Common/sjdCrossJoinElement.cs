namespace Belien2007.A.E.O.Classes.CrossJoinElements.Common
{
    using log4net;

    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class sjdCrossJoinElement : IsjdCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sjdCrossJoinElement(
            IsIndexElement sIndexElement,
            IjIndexElement jIndexElement,
            IdIndexElement dIndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.jIndexElement = jIndexElement;

            this.dIndexElement = dIndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IjIndexElement jIndexElement { get; }

        public IdIndexElement dIndexElement { get; }
    }
}