namespace Belien2007.A.E.O.Factories.Models.MIP2
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.Models.MIP2;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.Interfaces.Contexts.MIP2;
    using Belien2007.A.E.O.Interfaces.Models.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Models.MIP2;

    internal sealed class MIP2ModelFactory : IMIP2ModelFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MIP2ModelFactory()
        {
        }

        public IMIP2Model Create(
            IConstraintElementsAbstractFactory constraintElementsAbstractFactory,
            IConstraintsAbstractFactory constraintsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            ICrossJoinsAbstractFactory crossJoinsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IIndicesAbstractFactory indicesAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IParametersAbstractFactory parametersAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IMIP2InputContext MIP2InputContext)
        {
            IMIP2Model model = null;

            try
            {
                model = new MIP2Model(
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
                    MIP2InputContext);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return model;
        }
    }
}