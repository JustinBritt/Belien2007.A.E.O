namespace Belien2007.A.E.O.Factories.Calculations.Stochastic.StateNumberPatients
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.Calculations.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.Interfaces.Calculations.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Calculations.Stochastic.StateNumberPatients;

    internal sealed class StateNumberPatientsCalculationFactory : IStateNumberPatientsCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public StateNumberPatientsCalculationFactory()
        {
        }

        public IStateNumberPatientsCalculation Create()
        {
            IStateNumberPatientsCalculation calculation = null;

            try
            {
                calculation = new StateNumberPatientsCalculation();
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