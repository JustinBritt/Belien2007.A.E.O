namespace Belien2007.A.E.O.Factories.ResultElements.Common.DayBedOccupancyMeans
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.ResultElements.Common.DayBedOccupancyMeans;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayBedOccupancyMeans;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayBedOccupancyMeans;

    internal sealed class μResultElementFactory : IμResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public μResultElementFactory()
        {
        }

        public IμResultElement Create(
            IiIndexElement iIndexElement,
            decimal value)
        {
            IμResultElement resultElement = null;

            try
            {
                resultElement = new μResultElement(
                    iIndexElement,
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