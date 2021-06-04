namespace Belien2007.A.E.O.Factories.ObjectiveFunctions.QMIP
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.ObjectiveFunctions.QMIP;
    using Belien2007.A.E.O.Interfaces.ObjectiveFunctions.QMIP;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Variables.Common;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;
    using Belien2007.A.E.O.InterfacesFactories.ObjectiveFunctions.QMIP;

    internal sealed class QMIPObjectiveFunctionFactory : IQMIPObjectiveFunctionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public QMIPObjectiveFunctionFactory()
        {
        }

        public IQMIPObjectiveFunction Create(
            IObjectiveFactory objectiveFactory,
            Ii i,
            IA A,
            Iμ μ)
        {
            IQMIPObjectiveFunction objectiveFunction = null;

            try
            {
                objectiveFunction = new QMIPObjectiveFunction(
                    objectiveFactory,
                    i,
                    A,
                    μ);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return objectiveFunction;
        }
    }
}