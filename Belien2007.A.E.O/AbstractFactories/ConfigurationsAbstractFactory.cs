namespace Belien2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Factories.Configurations.MIP2;
    using Belien2007.A.E.O.Factories.Configurations.QMIP;
    using Belien2007.A.E.O.Factories.Configurations.SMIP2;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.InterfacesFactories.Configurations.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Configurations.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.Configurations.SMIP2;

    internal sealed class ConfigurationsAbstractFactory : IConfigurationsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConfigurationsAbstractFactory()
        {
        }

        public IMIP2ConfigurationFactory CreateMIP2ConfigurationFactory()
        {
            IMIP2ConfigurationFactory factory = null;

            try
            {
                factory = new MIP2ConfigurationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IQMIPConfigurationFactory CreateQMIPConfigurationFactory()
        {
            IQMIPConfigurationFactory factory = null;

            try
            {
                factory = new QMIPConfigurationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISMIP2ConfigurationFactory CreateSMIP2ConfigurationFactory()
        {
            ISMIP2ConfigurationFactory factory = null;

            try
            {
                factory = new SMIP2ConfigurationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}