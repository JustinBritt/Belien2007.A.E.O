namespace Belien2007.A.E.O.Factories.CrossJoinElements.Common
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.InterfacesFactories.CrossJoinElements.Common;

    internal sealed class sjdCrossJoinElementFactory : IsjdCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sjdCrossJoinElementFactory()
        {
        }

        public IsjdCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IjIndexElement jIndexElement,
            IdIndexElement dIndexElement)
        {
            IsjdCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new sjdCrossJoinElement(
                    sIndexElement,
                    jIndexElement,
                    dIndexElement);
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