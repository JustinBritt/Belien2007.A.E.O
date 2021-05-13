namespace Belien2007.A.E.O.Classes.Configurations.QMIP
{
    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using Belien2007.A.E.O.Interfaces.Configurations.QMIP;

    internal sealed class QMIPConfiguration : IQMIPConfiguration
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public QMIPConfiguration(
            Configuration configuration)
        {
            this.Value = configuration;
        }

        public Configuration Value { get; }
    }
}