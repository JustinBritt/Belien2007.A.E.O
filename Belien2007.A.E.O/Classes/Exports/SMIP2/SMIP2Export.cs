namespace Belien2007.A.E.O.Classes.Exports.SMIP2
{
    using System.Threading.Tasks;

    using log4net;

    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.Interfaces.Configurations.SMIP2;
    using Belien2007.A.E.O.Interfaces.Contexts.SMIP2;
    using Belien2007.A.E.O.Interfaces.Exports.SMIP2;
    using Belien2007.A.E.O.Interfaces.SolverConfigurations;

    public sealed class SMIP2Export : ISMIP2Export
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SMIP2Export()
        {
        }

        public Task<ISMIP2OutputContext> Solve(
            IAbstractFactory abstractFactory,
            ISMIP2Configuration SMIP2Configuration,
            ISMIP2InputContext SMIP2InputContext,
            ISolverConfiguration solverConfiguration)
        {
            return abstractFactory.CreateSolutionsAbstractFactory().CreateSMIP2SolutionFactory().Create().Solve(
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
                SMIP2Configuration,
                SMIP2InputContext,
                solverConfiguration);
        }
    }
}