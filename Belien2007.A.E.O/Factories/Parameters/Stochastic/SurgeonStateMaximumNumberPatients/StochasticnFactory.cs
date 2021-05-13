namespace Belien2007.A.E.O.Factories.Parameters.Stochastic.SurgeonStateMaximumNumberPatients
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Parameters.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Stochastic.SurgeonStateMaximumNumberPatients;

    internal sealed class StochasticnFactory : IStochasticnFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public StochasticnFactory()
        {
        }

        public IStochasticn Create(
            ImmutableList<IStochasticnParameterElement> value)
        {
            IStochasticn parameter = null;

            try
            {
                parameter = new Stochasticn(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameter;
        }
    }
}