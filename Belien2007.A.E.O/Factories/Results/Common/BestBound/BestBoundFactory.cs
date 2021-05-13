namespace Belien2007.A.E.O.Factories.Results.Common.BestBound
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.Results.Common.BestBound;
    using Belien2007.A.E.O.Interfaces.Results.Common.BestBound;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.BestBound;

    internal sealed class BestBoundFactory : IBestBoundFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BestBoundFactory()
        {
        }

        public IBestBound Create(
            decimal value)
        {
            IBestBound result = null;

            try
            {
                result = new BestBound(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return result;
        }
    }
}