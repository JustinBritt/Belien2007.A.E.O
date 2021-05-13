namespace Belien2007.A.E.O.InterfacesFactories.Parameters.Common.ActivePeriods
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;

    public interface IAFactory
    {
        IA Create(
            ImmutableList<IAParameterElement> value);
    }
}