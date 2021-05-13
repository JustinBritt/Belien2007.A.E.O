namespace Belien2007.A.E.O.Classes.Configurations.MIP2
{
    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using Belien2007.A.E.O.Interfaces.Configurations.MIP2;

    internal sealed class MIP2Configuration : IMIP2Configuration
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MIP2Configuration(
            Configuration configuration)
        {
            this.Value = configuration;
        }

        public Configuration Value { get; }
    }
}