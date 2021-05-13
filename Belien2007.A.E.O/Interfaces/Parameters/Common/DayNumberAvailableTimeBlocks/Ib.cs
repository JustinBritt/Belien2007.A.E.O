namespace Belien2007.A.E.O.Interfaces.Parameters.Common.DayNumberAvailableTimeBlocks
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayNumberAvailableTimeBlocks;

    public interface Ib
    {
        ImmutableList<IbParameterElement> Value { get; }

        int GetElementAtAsint(
            IiIndexElement iIndexElement);
    }
}