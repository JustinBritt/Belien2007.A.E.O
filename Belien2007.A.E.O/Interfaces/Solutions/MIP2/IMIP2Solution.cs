namespace Belien2007.A.E.O.Interfaces.Solutions.MIP2
{
    using System.Threading.Tasks;

    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.Interfaces.Configurations.MIP2;
    using Belien2007.A.E.O.Interfaces.Contexts.MIP2;
    using Belien2007.A.E.O.Interfaces.SolverConfigurations;

    public interface IMIP2Solution
    {
        Task<IMIP2OutputContext> Solve(
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
            IMIP2Configuration MIP2Configuration,
            IMIP2InputContext MIP2InputContext,
            ISolverConfiguration solverConfiguration);
    }
}