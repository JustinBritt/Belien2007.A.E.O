namespace Belien2007.A.E.O.Factories.Exports.MIP2
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.Exports.MIP2;
    using Belien2007.A.E.O.Interfaces.Exports.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Exports.MIP2;

    internal sealed class MIP2ExportFactory : IMIP2ExportFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MIP2ExportFactory()
        {
        }

        public IMIP2Export Create()
        {
            IMIP2Export export = null;

            try
            {
                export = new MIP2Export();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return export;
        }
    }
}