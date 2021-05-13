namespace Belien2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Belien2007.A.E.O.InterfacesAbstractFactories;

    public sealed class AbstractFactory : IAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AbstractFactory()
        {
        }

        public static IAbstractFactory Create()
        {
            return new AbstractFactory();
        }

        public ICalculationsAbstractFactory CreateCalculationsAbstractFactory()
        {
            ICalculationsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new CalculationsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return abstractFactory;
        }

        public IConfigurationsAbstractFactory CreateConfigurationsAbstractFactory()
        {
            IConfigurationsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ConfigurationsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return abstractFactory;
        }

        public IConstraintElementsAbstractFactory CreateConstraintElementsAbstractFactory()
        {
            IConstraintElementsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ConstraintElementsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return abstractFactory;
        }

        public IConstraintsAbstractFactory CreateConstraintsAbstractFactory()
        {
            IConstraintsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ConstraintsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return abstractFactory;
        }

        public IContextsAbstractFactory CreateContextsAbstractFactory()
        {
            IContextsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ContextsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return abstractFactory;
        }

        public ICrossJoinElementsAbstractFactory CreateCrossJoinElementsAbstractFactory()
        {
            ICrossJoinElementsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new CrossJoinElementsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return abstractFactory;
        }

        public ICrossJoinsAbstractFactory CreateCrossJoinsAbstractFactory()
        {
            ICrossJoinsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new CrossJoinsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return abstractFactory;
        }

        public IDependenciesAbstractFactory CreateDependenciesAbstractFactory()
        {
            IDependenciesAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new DependenciesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return abstractFactory;
        }

        public IExportsAbstractFactory CreateExportsAbstractFactory()
        {
            IExportsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ExportsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return abstractFactory;
        }

        public IIndexElementsAbstractFactory CreateIndexElementsAbstractFactory()
        {
            IIndexElementsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new IndexElementsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return abstractFactory;
        }

        public IIndicesAbstractFactory CreateIndicesAbstractFactory()
        {
            IIndicesAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new IndicesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return abstractFactory;
        }

        public IModelsAbstractFactory CreateModelsAbstractFactory()
        {
            IModelsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ModelsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return abstractFactory;
        }

        public IObjectiveFunctionsAbstractFactory CreateObjectiveFunctionsAbstractFactory()
        {
            IObjectiveFunctionsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ObjectiveFunctionsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return abstractFactory;
        }

        public IParameterElementsAbstractFactory CreateParameterElementsAbstractFactory()
        {
            IParameterElementsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ParameterElementsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return abstractFactory;
        }

        public IParametersAbstractFactory CreateParametersAbstractFactory()
        {
            IParametersAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ParametersAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return abstractFactory;
        }

        public IResultElementsAbstractFactory CreateResultElementsAbstractFactory()
        {
            IResultElementsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ResultElementsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return abstractFactory;
        }

        public IResultsAbstractFactory CreateResultsAbstractFactory()
        {
            IResultsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ResultsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return abstractFactory;
        }

        public ISolutionsAbstractFactory CreateSolutionsAbstractFactory()
        {
            ISolutionsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new SolutionsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return abstractFactory;
        }

        public ISolverConfigurationsAbstractFactory CreateSolverConfigurationsAbstractFactory()
        {
            ISolverConfigurationsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new SolverConfigurationsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return abstractFactory;
        }

        public IVariablesAbstractFactory CreateVariablesAbstractFactory()
        {
            IVariablesAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new VariablesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return abstractFactory;
        }
    }
}