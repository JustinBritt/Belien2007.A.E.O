namespace Belien2007.A.E.O.Factories.Configurations.QMIP
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using Belien2007.A.E.O.Classes.Configurations.QMIP;
    using Belien2007.A.E.O.Interfaces.Configurations.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.Configurations.QMIP;

    internal sealed class QMIPConfigurationFactory : IQMIPConfigurationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public QMIPConfigurationFactory()
        {
        }

        public IQMIPConfiguration Create(
            Configuration configuration)
        {
            IQMIPConfiguration QMIPConfiguration = null;

            try
            {
                QMIPConfiguration = new QMIPConfiguration(
                    configuration);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return QMIPConfiguration;
        }
    }
}