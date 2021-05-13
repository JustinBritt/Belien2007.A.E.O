namespace Belien2007.A.E.O.Factories.Exports.QMIP
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.Exports.QMIP;
    using Belien2007.A.E.O.Interfaces.Exports.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.Exports.QMIP;

    internal sealed class QMIPExportFactory : IQMIPExportFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public QMIPExportFactory()
        {
        }

        public IQMIPExport Create()
        {
            IQMIPExport export = null;

            try
            {
                export = new QMIPExport();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return export;
        }
    }
}