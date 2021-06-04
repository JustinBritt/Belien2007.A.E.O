namespace Belien2007.A.E.O.Factories.CrossJoinElements.Common
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.InterfacesFactories.CrossJoinElements.Common;

    internal sealed class siCrossJoinElementFactory : IsiCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public siCrossJoinElementFactory()
        {
        }

        public IsiCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IiIndexElement iIndexElement)
        {
            IsiCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new siCrossJoinElement(
                    sIndexElement,
                    iIndexElement);
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