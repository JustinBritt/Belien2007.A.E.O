namespace Belien2007.A.E.O.Factories.Results.Common.DayDaySurgeonNumberOccupiedBeds
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Results.Common.DayDaySurgeonNumberOccupiedBeds;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayDaySurgeonNumberOccupiedBeds;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayDaySurgeonNumberOccupiedBeds;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DayDaySurgeonNumberOccupiedBeds;

    internal sealed class UFactory : IUFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UFactory()
        {
        }

        public IU Create(
            ImmutableList<IUResultElement> value)
        {
            IU result = null;

            try
            {
                result = new U(
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