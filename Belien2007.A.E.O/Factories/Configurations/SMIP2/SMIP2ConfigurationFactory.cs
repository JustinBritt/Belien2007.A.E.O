namespace Belien2007.A.E.O.Factories.Configurations.SMIP2
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using Belien2007.A.E.O.Classes.Configurations.SMIP2;
    using Belien2007.A.E.O.Interfaces.Configurations.SMIP2;
    using Belien2007.A.E.O.InterfacesFactories.Configurations.SMIP2;

    internal sealed class SMIP2ConfigurationFactory : ISMIP2ConfigurationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SMIP2ConfigurationFactory()
        {
        }

        public ISMIP2Configuration Create(
            Configuration configuration)
        {
            ISMIP2Configuration SMIP2Configuration = null;

            try
            {
                SMIP2Configuration = new SMIP2Configuration(
                    configuration);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return SMIP2Configuration;
        }
    }
}