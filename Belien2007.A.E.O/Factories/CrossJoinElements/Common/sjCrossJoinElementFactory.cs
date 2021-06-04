namespace Belien2007.A.E.O.Factories.CrossJoinElements.Common
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.InterfacesFactories.CrossJoinElements.Common;

    internal sealed class sjCrossJoinElementFactory : IsjCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sjCrossJoinElementFactory()
        {
        }

        public IsjCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IjIndexElement jIndexElement)
        {
            IsjCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new sjCrossJoinElement(
                    sIndexElement,
                    jIndexElement);
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