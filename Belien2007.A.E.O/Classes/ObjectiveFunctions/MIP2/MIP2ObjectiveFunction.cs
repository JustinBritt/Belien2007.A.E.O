namespace Belien2007.A.E.O.Classes.ObjectiveFunctions.MIP2
{
    using log4net;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using Belien2007.A.E.O.Interfaces.ObjectiveFunctions.MIP2;
    using Belien2007.A.E.O.Interfaces.Variables.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class MIP2ObjectiveFunction : IMIP2ObjectiveFunction
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MIP2ObjectiveFunction(
            IObjectiveFactory objectiveFactory,
            Iγ γ)
        {
            Expression expression = γ.Value;

            Objective objective = objectiveFactory.Create(
                expression,
                ObjectiveSense.Minimize);

            this.Value = objective;
        }

        public Objective Value { get; }
    }
}