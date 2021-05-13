namespace Belien2007.A.E.O.Factories.ResultElements.Common.DayBedOccupancyVariances
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.ResultElements.Common.DayBedOccupancyVariances;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayBedOccupancyVariances;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayBedOccupancyVariances;

    internal sealed class VarianceResultElementFactory : IVarianceResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceResultElementFactory()
        {
        }

        public IVarianceResultElement Create(
            IiIndexElement iIndexElement,
            decimal value)
        {
            IVarianceResultElement resultElement = null;

            try
            {
                resultElement = new VarianceResultElement(
                    iIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return resultElement;
        }
    }
}