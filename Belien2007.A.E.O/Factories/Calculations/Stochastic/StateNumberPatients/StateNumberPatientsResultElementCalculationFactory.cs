namespace Belien2007.A.E.O.Factories.Calculations.Stochastic.StateNumberPatients
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.Calculations.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.Interfaces.Calculations.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Calculations.Stochastic.StateNumberPatients;

    internal sealed class StateNumberPatientsResultElementCalculationFactory : IStateNumberPatientsResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public StateNumberPatientsResultElementCalculationFactory()
        {
        }

        public IStateNumberPatientsResultElementCalculation Create()
        {
            IStateNumberPatientsResultElementCalculation calculation = null;

            try
            {
                calculation = new StateNumberPatientsResultElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}