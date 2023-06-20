namespace Belien2007.A.E.O.Classes.Solutions.SMIP2
{
    using System.Threading.Tasks;

    using log4net;

    using OPTANO.Modeling.Common;
    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Interfaces;

    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.Interfaces.Configurations.SMIP2;
    using Belien2007.A.E.O.Interfaces.Contexts.SMIP2;
    using Belien2007.A.E.O.Interfaces.Models.SMIP2;
    using Belien2007.A.E.O.Interfaces.Solutions.SMIP2;
    using Belien2007.A.E.O.Interfaces.SolverConfigurations;

    internal sealed class SMIP2Solution : ISMIP2Solution
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SMIP2Solution()
        {
        }

        public Task<ISMIP2OutputContext> Solve(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IComparersAbstractFactory comparersAbstractFactory,
            IConstraintElementsAbstractFactory constraintElementsAbstractFactory,
            IConstraintsAbstractFactory constraintsAbstractFactory,
            IContextsAbstractFactory contextsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            ICrossJoinsAbstractFactory crossJoinsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IIndicesAbstractFactory indicesAbstractFactory,
            IModelsAbstractFactory modelsAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IParametersAbstractFactory parametersAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            ISMIP2Configuration SMIP2Configuration,
            ISMIP2InputContext SMIP2InputContext,
            ISolverConfiguration solverConfiguration)
        {
            ISMIP2OutputContext SMIP2OutputContext = null;

            return Task.Run(() => 
            {
                using (ModelScope modelScope = dependenciesAbstractFactory.CreateModelScopeFactory().Create(SMIP2Configuration.Value))
                {
                    ISMIP2Model model = modelsAbstractFactory.CreateSMIP2ModelFactory().Create(
                        comparersAbstractFactory,
                        constraintElementsAbstractFactory,
                        constraintsAbstractFactory,
                        crossJoinElementsAbstractFactory,
                        crossJoinsAbstractFactory,
                        dependenciesAbstractFactory,
                        indexElementsAbstractFactory,
                        indicesAbstractFactory,
                        objectiveFunctionsAbstractFactory,
                        parameterElementsAbstractFactory,
                        parametersAbstractFactory,
                        variablesAbstractFactory,
                        SMIP2InputContext);

                    using (ISolver solver = dependenciesAbstractFactory.CreateSolverFactory().Create(solverConfiguration))
                    {
                        Solution solution = solver?.Solve(model?.Model);

                        if (solution?.ModelStatus == OPTANO.Modeling.Optimization.Solver.ModelStatus.Feasible)
                        {
                            model.Model.VariableCollections.ForEach(vc => vc.SetVariableValues(solution.VariableValues));

                            SMIP2OutputContext = contextsAbstractFactory.CreateSMIP2OutputContextFactory().Create(
                                calculationsAbstractFactory,
                                dependenciesAbstractFactory,
                                resultElementsAbstractFactory,
                                resultsAbstractFactory,
                                model,
                                solution);
                        }
                    }
                }

                return SMIP2OutputContext;
            });
        }
    }
}