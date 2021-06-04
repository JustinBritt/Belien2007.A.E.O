namespace Belien2007.A.E.O.Factories.Calculations.Stochastic.SurgeonStateNumberPatients
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.Calculations.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.Interfaces.Calculations.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Calculations.Stochastic.SurgeonStateNumberPatients;

    internal sealed class SurgeonStateNumberPatientsCalculationFactory : ISurgeonStateNumberPatientsCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonStateNumberPatientsCalculationFactory()
        {
        }

        public ISurgeonStateNumberPatientsCalculation Create()
        {
            ISurgeonStateNumberPatientsCalculation calculation = null;

            try
            {
                calculation = new SurgeonStateNumberPatientsCalculation();
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