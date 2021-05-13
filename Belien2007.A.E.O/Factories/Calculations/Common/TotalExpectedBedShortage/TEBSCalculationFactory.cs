namespace Belien2007.A.E.O.Factories.Calculations.Common.TotalExpectedBedShortage
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.Calculations.Common.TotalExpectedBedShortage;
    using Belien2007.A.E.O.Interfaces.Calculations.Common.TotalExpectedBedShortage;
    using Belien2007.A.E.O.InterfacesFactories.Calculations.Common.TotalExpectedBedShortage;

    internal sealed class TEBSCalculationFactory : ITEBSCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TEBSCalculationFactory()
        {
        }

        public ITEBSCalculation Create()
        {
            ITEBSCalculation calculation = null;

            try
            {
                calculation = new TEBSCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}