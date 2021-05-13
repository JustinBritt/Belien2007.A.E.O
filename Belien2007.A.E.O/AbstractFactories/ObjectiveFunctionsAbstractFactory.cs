namespace Belien2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Factories.ObjectiveFunctions.MIP2;
    using Belien2007.A.E.O.Factories.ObjectiveFunctions.QMIP;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.InterfacesFactories.ObjectiveFunctions.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.ObjectiveFunctions.QMIP;

    internal sealed class ObjectiveFunctionsAbstractFactory : IObjectiveFunctionsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveFunctionsAbstractFactory()
        {
        }

        public IMIP2ObjectiveFunctionFactory CreateMIP2ObjectiveFunctionFactory()
        {
            IMIP2ObjectiveFunctionFactory factory = null;

            try
            {
                factory = new MIP2ObjectiveFunctionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IQMIPObjectiveFunctionFactory CreateQMIPObjectiveFunctionFactory()
        {
            IQMIPObjectiveFunctionFactory factory = null;

            try
            {
                factory = new QMIPObjectiveFunctionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}