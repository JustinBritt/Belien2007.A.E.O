namespace Belien2007.A.E.O.Interfaces.Parameters.Common.DayBedCapacities
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayBedCapacities;

    public interface Ic
    {
        ImmutableList<IcParameterElement> Value { get; }

        int GetElementAtAsint(
            IiIndexElement iIndexElement);
    }
}