namespace Belien2007.A.E.O.Factories.Results.Common.DayBedOccupancyMeans
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Results.Common.DayBedOccupancyMeans;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayBedOccupancyMeans;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayBedOccupancyMeans;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DayBedOccupancyMeans;

    internal sealed class μFactory : IμFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public μFactory()
        {
        }

        public Iμ Create(
            ImmutableList<IμResultElement> value)
        {
            Iμ result = null;

            try
            {
                result = new μ(
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