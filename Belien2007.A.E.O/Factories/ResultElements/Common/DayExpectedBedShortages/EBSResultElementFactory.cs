namespace Belien2007.A.E.O.Factories.ResultElements.Common.DayExpectedBedShortages
{
    using System;
 
    using log4net;

    using Belien2007.A.E.O.Classes.ResultElements.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayExpectedBedShortages;

    internal sealed class EBSResultElementFactory : IEBSResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSResultElementFactory()
        {
        }

        public IEBSResultElement Create(
            IiIndexElement iIndexElement,
            decimal value)
        {
            IEBSResultElement resultElement = null;

            try
            {
                resultElement = new EBSResultElement(
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