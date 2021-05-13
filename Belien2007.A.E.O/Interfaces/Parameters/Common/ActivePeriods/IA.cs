namespace Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.ActivePeriods;

    public interface IA
    {
        ImmutableList<IAParameterElement> Value { get; }

        int GetElementAtAsint(
            IiIndexElement iIndexElement);

        int GetElementAtAsint(
            IjIndexElement jIndexElement);
    }
}