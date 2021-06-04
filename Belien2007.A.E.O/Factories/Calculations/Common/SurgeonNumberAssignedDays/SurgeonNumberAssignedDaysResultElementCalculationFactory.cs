namespace Belien2007.A.E.O.Factories.Calculations.Common.SurgeonNumberAssignedDays
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.Calculations.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.Interfaces.Calculations.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.InterfacesFactories.Calculations.Common.SurgeonNumberAssignedDays;

    internal sealed class SurgeonNumberAssignedDaysResultElementCalculationFactory : ISurgeonNumberAssignedDaysResultElementCalculationFactory    
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedDaysResultElementCalculationFactory()
        {
        }

        public ISurgeonNumberAssignedDaysResultElementCalculation Create()
        {
            ISurgeonNumberAssignedDaysResultElementCalculation calculation = null;

            try
            {
                calculation = new SurgeonNumberAssignedDaysResultElementCalculation();
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