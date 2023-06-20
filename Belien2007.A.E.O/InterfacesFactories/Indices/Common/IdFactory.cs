namespace Belien2007.A.E.O.InterfacesFactories.Indices.Common
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.Comparers;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;

    public interface IdFactory
    {
        Id Create(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IdIndexElement> value);
    }
}