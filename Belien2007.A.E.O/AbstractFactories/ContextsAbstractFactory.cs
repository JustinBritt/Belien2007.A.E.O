namespace Belien2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Factories.Contexts.MIP2;
    using Belien2007.A.E.O.Factories.Contexts.QMIP;
    using Belien2007.A.E.O.Factories.Contexts.SMIP2;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.InterfacesFactories.Contexts.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Contexts.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.Contexts.SMIP2;

    internal sealed class ContextsAbstractFactory : IContextsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ContextsAbstractFactory()
        {
        }

        public IMIP2InputContextFactory CreateMIP2InputContextFactory()
        {
            IMIP2InputContextFactory factory = null;

            try
            {
                factory = new MIP2InputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IMIP2OutputContextFactory CreateMIP2OutputContextFactory()
        {
            IMIP2OutputContextFactory factory = null;

            try
            {
                factory = new MIP2OutputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IQMIPInputContextFactory CreateQMIPInputContextFactory()
        {
            IQMIPInputContextFactory factory = null;

            try
            {
                factory = new QMIPInputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IQMIPOutputContextFactory CreateQMIPOutputContextFactory()
        {
            IQMIPOutputContextFactory factory = null;

            try
            {
                factory = new QMIPOutputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISMIP2InputContextFactory CreateSMIP2InputContextFactory()
        {
            ISMIP2InputContextFactory factory = null;

            try
            {
                factory = new SMIP2InputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISMIP2OutputContextFactory CreateSMIP2OutputContextFactory()
        {
            ISMIP2OutputContextFactory factory = null;

            try
            {
                factory = new SMIP2OutputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}