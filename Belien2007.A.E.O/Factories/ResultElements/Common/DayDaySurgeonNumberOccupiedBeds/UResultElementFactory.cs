namespace Belien2007.A.E.O.Factories.ResultElements.Common.DayDaySurgeonNumberOccupiedBeds
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.ResultElements.Common.DayDaySurgeonNumberOccupiedBeds;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayDaySurgeonNumberOccupiedBeds;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayDaySurgeonNumberOccupiedBeds;

    internal sealed class UResultElementFactory : IUResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UResultElementFactory()
        {
        }

        public IUResultElement Create(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IsIndexElement sIndexElement,
            decimal value)
        {
            IUResultElement resultElement = null;

            try
            {
                resultElement = new UResultElement(
                    iIndexElement,
                    jIndexElement,
                    sIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return resultElement;
        }
    }
}