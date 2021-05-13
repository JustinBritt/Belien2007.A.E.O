namespace Belien2007.A.E.O.Factories.Results.Common.DayBedOccupancyVariances
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Results.Common.DayBedOccupancyVariances;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayBedOccupancyVariances;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayBedOccupancyVariances;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DayBedOccupancyVariances;

    internal sealed class VarianceFactory : IVarianceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceFactory()
        {
        }

        public IVariance Create(
            ImmutableList<IVarianceResultElement> value)
        {
            IVariance result = null;

            try
            {
                result = new Variance(
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