namespace Belien2007.A.E.O.Factories.CrossJoinElements.Common
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.InterfacesFactories.CrossJoinElements.Common;

    internal sealed class sjd1d2CrossJoinElementFactory : Isjd1d2CrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sjd1d2CrossJoinElementFactory()
        {
        }

        public Isjd1d2CrossJoinElement Create(
            IsIndexElement sIndexElement,
            IjIndexElement jIndexElement,
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement)
        {
            Isjd1d2CrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new sjd1d2CrossJoinElement(
                    sIndexElement,
                    jIndexElement,
                    d1IndexElement,
                    d2IndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return crossJoinElement;
        }
    }
}