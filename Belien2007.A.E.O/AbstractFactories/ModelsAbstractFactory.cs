namespace Belien2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Factories.Models.MIP2;
    using Belien2007.A.E.O.Factories.Models.QMIP;
    using Belien2007.A.E.O.Factories.Models.SMIP2;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.InterfacesFactories.Models.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Models.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.Models.SMIP2;

    internal sealed class ModelsAbstractFactory : IModelsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ModelsAbstractFactory()
        {
        }

        public IMIP2ModelFactory CreateMIP2ModelFactory()
        {
            IMIP2ModelFactory factory = null;

            try
            {
                factory = new MIP2ModelFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IQMIPModelFactory CreateQMIPModelFactory()
        {
            IQMIPModelFactory factory = null;

            try
            {
                factory = new QMIPModelFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISMIP2ModelFactory CreateSMIP2ModelFactory()
        {
            ISMIP2ModelFactory factory = null;

            try
            {
                factory = new SMIP2ModelFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}