namespace Belien2007.A.E.O.Factories.CrossJoinElements.Common
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.InterfacesFactories.CrossJoinElements.Common;

    internal sealed class sjd1CrossJoinElementFactory : Isjd1CrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sjd1CrossJoinElementFactory()
        {
        }

        public Isjd1CrossJoinElement Create(
            IsIndexElement sIndexElement,
            IjIndexElement jIndexElement,
            Id1IndexElement d1IndexElement)
        {
            Isjd1CrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new sjd1CrossJoinElement(
                    sIndexElement,
                    jIndexElement,
                    d1IndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return crossJoinElement;
        }
    }
}