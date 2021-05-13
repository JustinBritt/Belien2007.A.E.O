namespace Belien2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Factories.Exports.MIP2;
    using Belien2007.A.E.O.Factories.Exports.QMIP;
    using Belien2007.A.E.O.Factories.Exports.SMIP2;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.InterfacesFactories.Exports.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Exports.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.Exports.SMIP2;

    internal sealed class ExportsAbstractFactory : IExportsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExportsAbstractFactory()
        {
        }

        public IMIP2ExportFactory CreateMIP2ExportFactory()
        {
            IMIP2ExportFactory factory = null;

            try
            {
                factory = new MIP2ExportFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IQMIPExportFactory CreateQMIPExportFactory()
        {
            IQMIPExportFactory factory = null;

            try
            {
                factory = new QMIPExportFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISMIP2ExportFactory CreateSMIP2ExportFactory()
        {
            ISMIP2ExportFactory factory = null;

            try
            {
                factory = new SMIP2ExportFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}