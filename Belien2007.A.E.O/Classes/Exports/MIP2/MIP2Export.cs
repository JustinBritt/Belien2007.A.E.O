namespace Belien2007.A.E.O.Classes.Exports.MIP2
{
    using System.Threading.Tasks;

    using log4net;

    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.Interfaces.Configurations.MIP2;
    using Belien2007.A.E.O.Interfaces.Contexts.MIP2;
    using Belien2007.A.E.O.Interfaces.Exports.MIP2;
    using Belien2007.A.E.O.Interfaces.SolverConfigurations;

    public sealed class MIP2Export : IMIP2Export
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MIP2Export()
        {
        }

        public Task<IMIP2OutputContext> Solve(
            IAbstractFactory abstractFactory,
            IMIP2Configuration MIP2Configuration,
            IMIP2InputContext MIP2InputContext,
            ISolverConfiguration solverConfiguration)
        {
            return abstractFactory.CreateSolutionsAbstractFactory().CreateMIP2SolutionFactory().Create().Solve(
                abstractFactory.CreateCalculationsAbstractFactory(),
                abstractFactory.CreateComparersAbstractFactory(),
                abstractFactory.CreateConstraintElementsAbstractFactory(),
                abstractFactory.CreateConstraintsAbstractFactory(),
                abstractFactory.CreateContextsAbstractFactory(),
                abstractFactory.CreateCrossJoinElementsAbstractFactory(),
                abstractFactory.CreateCrossJoinsAbstractFactory(),
                abstractFactory.CreateDependenciesAbstractFactory(),
                abstractFactory.CreateIndexElementsAbstractFactory(),
                abstractFactory.CreateIndicesAbstractFactory(),
                abstractFactory.CreateModelsAbstractFactory(),
                abstractFactory.CreateObjectiveFunctionsAbstractFactory(),
                abstractFactory.CreateParameterElementsAbstractFactory(),
                abstractFactory.CreateParametersAbstractFactory(),
                abstractFactory.CreateResultElementsAbstractFactory(),
                abstractFactory.CreateResultsAbstractFactory(),
                abstractFactory.CreateVariablesAbstractFactory(),
                MIP2Configuration,
                MIP2InputContext,
                solverConfiguration);
        }
    }
}