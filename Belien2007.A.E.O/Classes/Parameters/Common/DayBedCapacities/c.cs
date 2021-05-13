namespace Belien2007.A.E.O.Classes.Parameters.Common.DayBedCapacities
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayBedCapacities;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayBedCapacities;

    internal sealed class c : Ic
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public c(
            ImmutableList<IcParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IcParameterElement> Value { get; }

        public int GetElementAtAsint(
            IiIndexElement iIndexElement)
        {
            return this.Value
                .Where(x => x.iIndexElement == iIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}