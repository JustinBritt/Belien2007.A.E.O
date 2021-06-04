namespace Belien2007.A.E.O.Factories.CrossJoinElements.Stochastic
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.CrossJoinElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.InterfacesFactories.CrossJoinElements.Stochastic;

    internal sealed class skCrossJoinElementFactory : IskCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public skCrossJoinElementFactory()
        {
        }

        public IskCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IkIndexElement kIndexElement)
        {
            IskCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new skCrossJoinElement(
                    sIndexElement,
                    kIndexElement);
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