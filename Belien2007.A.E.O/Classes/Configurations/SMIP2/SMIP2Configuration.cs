namespace Belien2007.A.E.O.Classes.Configurations.SMIP2
{
    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using Belien2007.A.E.O.Interfaces.Configurations.SMIP2;

    internal sealed class SMIP2Configuration : ISMIP2Configuration
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SMIP2Configuration(
            Configuration configuration)
        {
            this.Value = configuration;
        }

        public Configuration Value { get; }
    }
}