namespace Belien2007.A.E.O.Classes.CrossJoinElements.Common
{
    using log4net;

    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class sjd1d2CrossJoinElement : Isjd1d2CrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sjd1d2CrossJoinElement(
            IsIndexElement sIndexElement,
            IjIndexElement jIndexElement,
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.jIndexElement = jIndexElement;

            this.d1IndexElement = d1IndexElement;

            this.d2IndexElement = d2IndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IjIndexElement jIndexElement { get; }

        public Id1IndexElement d1IndexElement { get; }

        public Id2IndexElement d2IndexElement { get; }
    }
}