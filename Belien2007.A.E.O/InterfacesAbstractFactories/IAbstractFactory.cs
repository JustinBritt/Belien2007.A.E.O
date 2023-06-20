namespace Belien2007.A.E.O.InterfacesAbstractFactories
{
    public interface IAbstractFactory
    {
        ICalculationsAbstractFactory CreateCalculationsAbstractFactory();

        IComparersAbstractFactory CreateComparersAbstractFactory();

        IConfigurationsAbstractFactory CreateConfigurationsAbstractFactory();

        IConstraintElementsAbstractFactory CreateConstraintElementsAbstractFactory();

        IConstraintsAbstractFactory CreateConstraintsAbstractFactory();

        IContextsAbstractFactory CreateContextsAbstractFactory();

        ICrossJoinElementsAbstractFactory CreateCrossJoinElementsAbstractFactory();

        ICrossJoinsAbstractFactory CreateCrossJoinsAbstractFactory();

        IDependenciesAbstractFactory CreateDependenciesAbstractFactory();

        IExportsAbstractFactory CreateExportsAbstractFactory();

        IIndexElementsAbstractFactory CreateIndexElementsAbstractFactory();

        IIndicesAbstractFactory CreateIndicesAbstractFactory();

        IModelsAbstractFactory CreateModelsAbstractFactory();

        IObjectiveFunctionsAbstractFactory CreateObjectiveFunctionsAbstractFactory();

        IParameterElementsAbstractFactory CreateParameterElementsAbstractFactory();

        IParametersAbstractFactory CreateParametersAbstractFactory();

        IResultElementsAbstractFactory CreateResultElementsAbstractFactory();

        IResultsAbstractFactory CreateResultsAbstractFactory();

        ISolutionsAbstractFactory CreateSolutionsAbstractFactory();

        ISolverConfigurationsAbstractFactory CreateSolverConfigurationsAbstractFactory();

        IVariablesAbstractFactory CreateVariablesAbstractFactory();
    }
}