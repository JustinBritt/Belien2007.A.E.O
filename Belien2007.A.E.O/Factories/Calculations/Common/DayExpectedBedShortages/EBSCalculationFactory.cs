namespace Belien2007.A.E.O.Factories.Calculations.Common.DayExpectedBedShortages
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.Calculations.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.Interfaces.Calculations.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.InterfacesFactories.Calculations.Common.DayExpectedBedShortages;

    internal sealed class EBSCalculationFactory : IEBSCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSCalculationFactory()
        {
        }

        public IEBSCalculation Create()
        {
            IEBSCalculation calculation = null;

            try
            {
                calculation = new EBSCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return calculation;
        }
    }
}