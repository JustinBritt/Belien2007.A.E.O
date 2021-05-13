namespace Belien2007.A.E.O.Classes.CrossJoinElements.Common
{
    using log4net;

    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class sjd1CrossJoinElement : Isjd1CrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sjd1CrossJoinElement(
            IsIndexElement sIndexElement,
            IjIndexElement jIndexElement,
            Id1IndexElement d1IndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.jIndexElement = jIndexElement;

            this.d1IndexElement = d1IndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IjIndexElement jIndexElement { get; }

        public Id1IndexElement d1IndexElement { get; }
    }
}