namespace Belien2007.A.E.O.Factories.Models.SMIP2
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.Models.SMIP2;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.Interfaces.Contexts.SMIP2;
    using Belien2007.A.E.O.Interfaces.Models.SMIP2;
    using Belien2007.A.E.O.InterfacesFactories.Models.SMIP2;

    internal sealed class SMIP2ModelFactory : ISMIP2ModelFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SMIP2ModelFactory()
        {
        }

        public ISMIP2Model Create(
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
            ISMIP2InputContext SMIP2InputContext)
        {
            ISMIP2Model model = null;

            try
            {
                model = new SMIP2Model(
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