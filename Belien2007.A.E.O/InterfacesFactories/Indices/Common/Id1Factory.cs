namespace Belien2007.A.E.O.InterfacesFactories.Indices.Common
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.Comparers;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;

    public interface Id1Factory
    {
        Id1 Create(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<Id1IndexElement> value);
    }
}