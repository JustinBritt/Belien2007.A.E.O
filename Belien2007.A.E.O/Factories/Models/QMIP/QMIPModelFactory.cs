﻿namespace Belien2007.A.E.O.Factories.Models.QMIP
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.Models.QMIP;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.Interfaces.Contexts.QMIP;
    using Belien2007.A.E.O.Interfaces.Models.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.Models.QMIP;

    internal sealed class QMIPModelFactory : IQMIPModelFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public QMIPModelFactory()
        {
        }

        public IQMIPModel Create(
            IComparersAbstractFactory comparersAbstractFactory,
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
            IQMIPInputContext QMIPInputContext)
        {
            IQMIPModel model = null;

            try
            {
                model = new QMIPModel(
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
                    QMIPInputContext);
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