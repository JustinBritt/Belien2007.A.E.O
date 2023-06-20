namespace Belien2007.A.E.O.InterfacesFactories.Indices.Common
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.Comparers;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;

    public interface Id2Factory
    {
        Id2 Create(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<Id2IndexElement> value);
    }
}