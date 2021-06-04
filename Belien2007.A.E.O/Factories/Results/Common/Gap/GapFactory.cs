namespace Belien2007.A.E.O.Factories.Results.Common.Gap
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.Results.Common.Gap;
    using Belien2007.A.E.O.Interfaces.Results.Common.Gap;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.Gap;

    internal sealed class GapFactory : IGapFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GapFactory()
        {
        }

        public IGap Create(
            decimal value)
        {
            IGap result = null;

            try
            {
                result = new Gap(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}