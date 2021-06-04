namespace Belien2007.A.E.O.Factories.ResultElements.Stochastic.StateNumberPatients
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.ResultElements.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Stochastic.StateNumberPatients;

    internal sealed class StateNumberPatientsResultElementFactory : IStateNumberPatientsResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public StateNumberPatientsResultElementFactory()
        {
        }

        public IStateNumberPatientsResultElement Create(
            IkIndexElement kIndexElement,
            int value)
        {
            IStateNumberPatientsResultElement resultElement = null;

            try
            {
                resultElement = new StateNumberPatientsResultElement(
                    kIndexElement,
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