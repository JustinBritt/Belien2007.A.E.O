namespace Belien2007.A.E.O.Factories.Exports.SMIP2
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.Exports.SMIP2;
    using Belien2007.A.E.O.Interfaces.Exports.SMIP2;
    using Belien2007.A.E.O.InterfacesFactories.Exports.SMIP2;

    internal sealed class SMIP2ExportFactory : ISMIP2ExportFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SMIP2ExportFactory()
        {
        }

        public ISMIP2Export Create()
        {
            ISMIP2Export export = null;

            try
            {
                export = new SMIP2Export();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return export;
        }
    }
}