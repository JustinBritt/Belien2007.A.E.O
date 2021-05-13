namespace Belien2007.A.E.O.Factories.CrossJoinElements.Common
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.InterfacesFactories.CrossJoinElements.Common;

    internal sealed class d1d2CrossJoinElementFactory : Id1d2CrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1d2CrossJoinElementFactory()
        {
        }

        public Id1d2CrossJoinElement Create(
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement)
        {
            Id1d2CrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new d1d2CrossJoinElement(
                    d1IndexElement,
                    d2IndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return crossJoinElement;
        }
    }
}