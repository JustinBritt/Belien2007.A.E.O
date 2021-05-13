namespace Belien2007.A.E.O.Classes.Parameters.Common.DayNumberAvailableTimeBlocks
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayNumberAvailableTimeBlocks;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayNumberAvailableTimeBlocks;

    internal sealed class b : Ib
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public b(
            ImmutableList<IbParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IbParameterElement> Value { get; }

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