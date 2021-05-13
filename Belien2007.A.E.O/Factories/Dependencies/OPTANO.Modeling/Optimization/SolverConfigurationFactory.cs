namespace Belien2007.A.E.O.Factories.Dependencies.OPTANO.Modeling.Optimization
{
    using System;
    using System.Linq;

    using log4net;

    using global::OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class SolverConfigurationFactory : ISolverConfigurationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SolverConfigurationFactory()
        {
        }

        public SolverConfiguration Create<T>()
            where T : global::OPTANO.Modeling.Optimization.SolverConfiguration
        {
            global::OPTANO.Modeling.Optimization.SolverConfiguration solverConfiguration = null;

            try
            {
                solverConfiguration = (SolverConfiguration)Activator.CreateInstance(
                    this.GetSolverConfigurationType<T>());
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return solverConfiguration;
        }

        private Type GetSolverConfigurationType<T>()
            where T : global::OPTANO.Modeling.Optimization.SolverConfiguration
        {
            return typeof(T)
                .Assembly
                .GetExportedTypes()
                .Where(w => w.FullName == typeof(T).FullName)
                .SingleOrDefault();
        }
    }
}