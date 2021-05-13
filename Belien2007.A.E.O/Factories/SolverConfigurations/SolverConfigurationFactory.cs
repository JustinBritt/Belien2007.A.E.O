namespace Belien2007.A.E.O.Factories.SolverConfigurations
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.SolverConfigurations;
    using Belien2007.A.E.O.Interfaces.SolverConfigurations;
    using Belien2007.A.E.O.InterfacesFactories.SolverConfigurations;

    internal sealed class SolverConfigurationFactory : ISolverConfigurationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SolverConfigurationFactory()
        {
        }

        public ISolverConfiguration Create(
            OPTANO.Modeling.Optimization.SolverConfiguration solverConfiguration)
        {
            ISolverConfiguration instance = null;

            try
            {
                instance = new SolverConfiguration(
                    solverConfiguration);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return instance;
        }
    }
}