namespace Belien2007.A.E.O.InterfacesFactories.Parameters.Common.DayBedCapacities
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayBedCapacities;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayBedCapacities;

    public interface IcFactory
    {
        Ic Create(
            ImmutableList<IcParameterElement> value);
    }
}