namespace Belien2007.A.E.O.Classes.CrossJoinElements.Common
{
    using log4net;

    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class sjCrossJoinElement : IsjCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sjCrossJoinElement(
            IsIndexElement sIndexElement,
            IjIndexElement jIndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.jIndexElement = jIndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IjIndexElement jIndexElement { get; }
    }
}