namespace Belien2007.A.E.O.Factories.Configurations.MIP2
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using Belien2007.A.E.O.Classes.Configurations.MIP2;
    using Belien2007.A.E.O.Interfaces.Configurations.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Configurations.MIP2;

    internal sealed class MIP2ConfigurationFactory : IMIP2ConfigurationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MIP2ConfigurationFactory()
        {
        }

        public IMIP2Configuration Create(
            Configuration configuration)
        {
            IMIP2Configuration MIP2Configuration = null;

            try
            {
                MIP2Configuration = new MIP2Configuration(
                    configuration);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return MIP2Configuration;
        }
    }
}