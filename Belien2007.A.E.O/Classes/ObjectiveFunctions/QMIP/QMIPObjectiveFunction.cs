namespace Belien2007.A.E.O.Classes.ObjectiveFunctions.QMIP
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.ObjectiveFunctions.QMIP;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Variables.Common;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class QMIPObjectiveFunction : IQMIPObjectiveFunction
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public QMIPObjectiveFunction(
            IObjectiveFactory objectiveFactory,
            Ii i,
            IA A,
            Iμ μ)
        {
            Expression expression = Expression.Sum(
                i.Value.Values
                .Where(y => A.GetElementAtAsint(y) == 1)
                .Select(
                    z => 
                    μ.Value[z] 
                    * 
                    μ.Value[z]));

            Objective objective = objectiveFactory.Create(
                expression,
                ObjectiveSense.Minimize);

            this.Value = objective;
        }

        public Objective Value { get; }
    }
}