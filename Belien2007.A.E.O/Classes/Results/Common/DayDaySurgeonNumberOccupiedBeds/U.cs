namespace Belien2007.A.E.O.Classes.Results.Common.DayDaySurgeonNumberOccupiedBeds
{
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayDaySurgeonNumberOccupiedBeds;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayDaySurgeonNumberOccupiedBeds;

    internal sealed class U : IU
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public U(
            ImmutableList<IUResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IUResultElement> Value { get; }
    }
}