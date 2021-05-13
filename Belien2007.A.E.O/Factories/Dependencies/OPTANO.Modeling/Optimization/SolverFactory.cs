namespace Belien2007.A.E.O.Factories.Dependencies.OPTANO.Modeling.Optimization
{
    using System;
    using System.Linq;

    using log4net;

    using global::OPTANO.Modeling.Optimization.Interfaces;

    using Belien2007.A.E.O.Interfaces.SolverConfigurations;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class SolverFactory : ISolverFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SolverFactory()
        {
        }

        public ISolver Create(
            ISolverConfiguration solverConfiguration)
        {
            ISolver solver = null;

            try
            {
                solver = (ISolver)Activator.CreateInstance(
                    this.GetSolverType(
                        solverConfiguration),
                    solverConfiguration.Value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return solver;
        }

        private Type GetSolverType(
            ISolverConfiguration solverConfiguration)
        {
            return solverConfiguration.Value
                .GetType()
                .Assembly
                .GetExportedTypes()
                .Select(w => Tuple.Create(w, w.GetConstructors().ToList()))
                .Select(w => Tuple.Create(w.Item1, w.Item2, w.Item2.Select(x => x.GetParameters()).SelectMany(y => y).ToList()))
                .Select(w => Tuple.Create(w.Item1, w.Item2, w.Item3, w.Item3.Select(x => x.ParameterType).ToList()))
                .Select(w => Tuple.Create(w.Item1, w.Item2, w.Item3, w.Item4, w.Item4.Select(x => x.FullName).ToList()))
                .Where(w => w.Item5.Contains(solverConfiguration.Value.GetType().FullName))
                .Select(w => w.Item1)
                .SingleOrDefault();
        }
    }
}