namespace Belien2007.A.E.O.Factories.Results.Stochastic.StateNumberPatients
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Results.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.Interfaces.Results.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Results.Stochastic.StateNumberPatients;

    internal sealed class StateNumberPatientsFactory : IStateNumberPatientsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public StateNumberPatientsFactory()
        {
        }

        public IStateNumberPatients Create(
            ImmutableList<IStateNumberPatientsResultElement> value)
        {
            IStateNumberPatients result = null;

            try
            {
                result = new StateNumberPatients(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}